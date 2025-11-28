using System;

namespace GOSO_Hotel.Model.Model
{

    public class CheckInOutModel
    {
        // Identifiers
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public int RoomId { get; set; }

        // Guest / reservation fields shown on the check-in UI
        public string CustomerName { get; set; }
        public string RoomType { get; set; }
        public string RoomNumber { get; set; }
        public string RoomGuest { get; set; }
        public int NumberOfGuests { get; set; }

        // Dates
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public TimeSpan? TimeOfArrival { get; set; }

        // Payment / charges
        public string PaymentStatus { get; set; }
        public decimal TotalPricePerNight { get; set; }
        public decimal AmountToPay { get; set; } // amount expected to be paid on check-in
        public decimal AmountPaid { get; set; }
        public decimal AmountPaidBefore { get; set; }

        // Status / notes
        public string Status { get; set; } 

        // Audit
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int Nights
        {
            get
            {
                if (!CheckInDate.HasValue || !CheckOutDate.HasValue) return 0;
                var days = (CheckOutDate.Value.Date - CheckInDate.Value.Date).Days;
                return days > 0 ? days : 0;
            }
        }
        public decimal CalculatedTotalAmount
        {
            get
            {
                return Nights * TotalPricePerNight;
            }
        }
        public decimal Balance
        {
            get
            {
                var paid = AmountPaidBefore + AmountPaid;
                var total = CalculatedTotalAmount;
                return total - paid;
            }
        }
    }
}
