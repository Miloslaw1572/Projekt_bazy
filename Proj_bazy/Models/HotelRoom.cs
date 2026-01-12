using System.ComponentModel.DataAnnotations;

namespace Proj_bazy.Models
{
    public class HotelRoom
    {
        public int Id { get; set; }
        [Required]
        public string Number { get; set; }
        public int RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
