using System.ComponentModel.DataAnnotations;

namespace Proj_bazy.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public int HotelRoomId { get; set; }
        public virtual HotelRoom? HotelRoom { get; set; }
        public string? UserId { get; set; }
        public virtual ApplicationUser? User { get; set; }
    }
}