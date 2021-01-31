using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using homey_api.Entities;
using Microsoft.EntityFrameworkCore;

namespace homey_api.Data
{
    public class Seed
    {
        public static async Task SeedHomes(DataContext context) 
        {
            if(await context.Houses.AnyAsync()) return;

            var houseData = await System.IO.File.ReadAllTextAsync("Data/HouseSeedData.json");
            var houses = JsonSerializer.Deserialize<List<House>>(houseData);
            foreach (var house in houses) {
                context.Houses.Add(house);
            }
            await context.SaveChangesAsync();
        }   
    }
}