using System.Collections.Generic;

namespace homey_api.DTOs
{
    public class HouseDTO
    {
        public int Id { get; set; }

        public ICollection<RoomDTO> Rooms { get; set; }
    }
}