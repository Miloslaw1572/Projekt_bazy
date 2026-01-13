using System.ComponentModel.DataAnnotations;

namespace Proj_bazy.Models
{
    public class RoomType
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal PricePerNight { get; set; }
        public virtual ICollection<HotelRoom> Rooms { get; set; }
    }
}