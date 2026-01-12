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
        public HotelRoom HotelRoom { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
