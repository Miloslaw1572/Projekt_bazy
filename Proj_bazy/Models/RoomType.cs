using System.ComponentModel.DataAnnotations;

namespace Proj_bazy.Models
{
    public class RoomType
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nazwa jest wymagana")]
        public string Name { get; set; }
        public decimal PricePerNight { get; set; }
        public ICollection<HotelRoom> Rooms { get; set; }
    }
}
