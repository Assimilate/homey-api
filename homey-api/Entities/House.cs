using System.Collections.Generic;

namespace homey_api.Entities
{
    public class House
    {
        public int Id { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}