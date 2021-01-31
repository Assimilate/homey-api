using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using homey_api.Data;
using homey_api.DTOs;
using homey_api.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace homey_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HousesController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public HousesController(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpGet("{id}/data")]
        public async Task<ActionResult<HouseDTO>> GetHouse(int id)
        {
            var house = await _context.Houses
            .Include(r => r.Rooms)
            .SingleOrDefaultAsync(house => house.Id == id);

            // Simulates a change in the temperature before sending the data back to the frontend.
            foreach(var room in house.Rooms) {
                var newTemperature = new Random().Next(19, 32);
                room.temperature = newTemperature;
            }
            await _context.SaveChangesAsync(); 

            return _mapper.Map<HouseDTO>(house);
        }

    }
}