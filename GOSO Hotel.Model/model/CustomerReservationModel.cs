using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOSO_Hotel.Model.Model
{
    public class CustomerReservationModel
    {

        //Customer
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string IdType { get; set; }
        public string IdNumber { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }


        // Reservation

        public int ReservationId { get; set; }
        public string RoomType { get; set; }
        public string RoomNumber { get; set; }
        public string ReservationStatus { get; set; }
        public TimeSpan? TimeOfArrival { get; set; }
        public string RoomGuest { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public decimal TotalPricePerNight { get; set; }
        public decimal AmountToPay { get; set; }
        public string PaymentStatus { get; set; }

        // New payment fields
        public decimal AmountPaid { get; set; }
        public decimal ChangeDue { get; set; }
    }
}
