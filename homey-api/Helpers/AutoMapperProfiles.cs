using AutoMapper;
using homey_api.DTOs;
using homey_api.Entities;

namespace homey_api.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles() {
            CreateMap<House, HouseDTO>();
            CreateMap<Room, RoomDTO>();
        }
    }
}