using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOSO_Hotel.Model.Model
{
    public class BillingModel
    {
        // Identifiers
        public int PaymentId { get; set; }
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public string GuestName { get; set; }
        public string Gender { get; set; }
        public string RoomType { get; set; }
        public string RoomNumber { get; set; }
        public int NumberOfGuests { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }

        // Charges
        public decimal RoomRate { get; set; } 
        public decimal LateCheckoutFee { get; set; }
        public decimal DamageFee { get; set; }

        // Payment summary
        public decimal AmountPaidBefore { get; set; }
        public decimal AmountPaidNow { get; set; }
        public decimal TotalAmount { get; set; }

        public DateTime? PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }

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
        public decimal SubTotal
        {
            get
            {
                var nights = Nights;
                return (nights * RoomRate) + LateCheckoutFee + DamageFee;
            }
        }

        public decimal EffectiveTotal => TotalAmount > 0 ? TotalAmount : SubTotal;
        public decimal TotalPaid => AmountPaidBefore + AmountPaidNow;
        public decimal Balance => EffectiveTotal - TotalPaid;
        public void ClearPayments()
        {
            AmountPaidBefore = 0m;
            AmountPaidNow = 0m;
            PaymentDate = null;
            PaymentMethod = null;
            PaymentStatus = null;
        }
    }
}
