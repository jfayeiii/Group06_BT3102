using GOSO_Hotel.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOSO_Hotel.Controller
{
    public class CheckInOutController
    {
        private GuestRecordRepository _guestRepo;

        public CheckInOutController()
        {
            _guestRepo = new GuestRecordRepository();
        }

        public string CheckIn(int customerId)
        {
            return _guestRepo.CheckInGuest(customerId);
        }

        public string CheckOut(int customerId)
        {
            return _guestRepo.CheckOutGuest(customerId);
        }
    }
}