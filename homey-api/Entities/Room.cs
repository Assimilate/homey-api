using System.ComponentModel.DataAnnotations.Schema;

namespace homey_api.Entities
{
    [Table("Rooms")]
    public class Room
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int temperature { get; set; }

        public House House { get; set;}

        public int HouseId { get; set; }
    }
}