using System.ComponentModel.DataAnnotations;

namespace Proj_bazy.Models
{
    public class HotelRoom
    {
        public int Id { get; set; }
        [Required]
        public string Number { get; set; }
        public int RoomTypeId { get; set; }
        public virtual RoomType? RoomType { get; set; }
        public virtual ICollection<Reservation>? Reservations { get; set; }
    }
}