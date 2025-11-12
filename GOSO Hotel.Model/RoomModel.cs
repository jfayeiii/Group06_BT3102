using System;

namespace GOSO_Hotel.Model
{
    public class RoomModel
    {
        public int Id { get; set; }
        public int RoomNo { get; set; }
        public string RoomType { get; set; }
        public decimal PricePerNight { get; set; }
        public int Capacity { get; set; }
        public int NoOfBeds { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
