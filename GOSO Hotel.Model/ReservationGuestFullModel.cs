using System;

namespace GOSO_Hotel.Model
{
   
    public class ReservationGuestFullModel
    {
        // Customer details
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string IdType { get; set; }
        public string IdNumber { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        // Reservation details
        public int ReservationId { get; set; }
        public int? RoomId { get; set; }
        public string RoomType { get; set; }
        public string RoomNumber { get; set; }
        public string ReservationStatus { get; set; }
        public TimeSpan? TimeOfArrival { get; set; }
        public int NumberOfGuests { get; set; }
        public string RoomGuest { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public decimal TotalPricePerNight { get; set; }

        // Billing / payment
        public int PaymentId { get; set; }
        public decimal AmountDue { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal Tax { get; set; }
        public decimal Discount { get; set; }
        public string PaymentStatus { get; set; }
        public string PaymentMethod { get; set; }
        public string TransactionId { get; set; }

        // Audit
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        // Computed helper properties
        public decimal Balance => (AmountDue + Tax - Discount) - AmountPaid;

        public int Nights
        {
            get
            {
                if (CheckInDate.HasValue && CheckOutDate.HasValue)
                {
                    var nights = (CheckOutDate.Value.Date - CheckInDate.Value.Date).Days;
                    return nights > 0 ? nights : 0;
                }

                return 0;
            }
        }

        public decimal EstimatedTotal
        {
            get
            {
                return Nights * TotalPricePerNight;
            }
        }
    }
}