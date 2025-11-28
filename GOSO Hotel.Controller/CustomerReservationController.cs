using System;
using System.Collections.Generic;
using GOSO_Hotel.Model.Model;
using GOSO_Hotel.Repository;
using System.Text.RegularExpressions;
using GOSO_Hotel.Model;

namespace GOSO_Hotel.Controller
{
    public class CustomerReservationController
    {
#region Code
        private readonly CustomerReservationRepository _repository;
        private readonly RoomRepository _roomRepository;

        public CustomerReservationController()
        {
            _repository = new CustomerReservationRepository();
            _roomRepository = new RoomRepository();
        }

        public (bool isValid, string errorMessage) ValidateReservation(CustomerReservationModel model)
        {
            var errors = new List<string>();

            if (model == null)
            {
                errors.Add("Reservation is empty.");
                return (false, string.Join("\n", errors));
            }

            if (string.IsNullOrWhiteSpace(model.CustomerName))
                errors.Add("Customer name is required.");

            if (string.IsNullOrWhiteSpace(model.Gender))
                errors.Add("Gender is required. Allowed values: Male, Female, Other.");
            else
            {
                var g = model.Gender.Trim();
                if (!(g.Equals("Male", StringComparison.OrdinalIgnoreCase) || g.Equals("Female", StringComparison.OrdinalIgnoreCase) || g.Equals("Other", StringComparison.OrdinalIgnoreCase)))
                    errors.Add("Gender must be one of: Male, Female or Other.");
            }

            if (string.IsNullOrWhiteSpace(model.Contact))
                errors.Add("Contact is required. Example: +1234567890 or 09171234567");
            else
            {
                var cleaned = string.Empty;
                for (int i = 0; i < model.Contact.Length; i++)
                {
                    if (char.IsDigit(model.Contact[i]) || model.Contact[i] == '+') cleaned += model.Contact[i];
                }
                if (cleaned.Length < 7)
                    errors.Add("Contact appears invalid — include digits and optional leading '+', minimum 7 digits. Example: +1234567890");
            }

            if (!string.IsNullOrWhiteSpace(model.Email))
            {
                try
                {
                    var emailPattern = "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$";
                    if (!Regex.IsMatch(model.Email, emailPattern))
                        errors.Add("Email is invalid. Expected format: user@example.com");
                }
                catch
                {
                    errors.Add("Email validation failed. Expected format: user@example.com");
                }
            }

            if (string.IsNullOrWhiteSpace(model.Address))
                errors.Add("Address is required (street, city, etc.). Example: 123 Main St, City");

            if (string.IsNullOrWhiteSpace(model.IdType))
                errors.Add("ID Type is required. Example: Passport, Driver's License, National ID");

            if (string.IsNullOrWhiteSpace(model.IdNumber) || model.IdNumber.Trim().Length < 3)
                errors.Add("ID Number is required and must be at least 3 characters. Example: A12345");

            if (string.IsNullOrWhiteSpace(model.RoomType))
                errors.Add("Room type is required. Choose from available room types.");

            if (string.IsNullOrWhiteSpace(model.RoomNumber))
                errors.Add("Room number is required. Select an available room for the chosen type and dates.");

            if (string.IsNullOrWhiteSpace(model.RoomGuest))
                errors.Add("Room guest name is required. Example: John Doe");

            if (string.IsNullOrWhiteSpace(model.ReservationStatus))
                errors.Add("Reservation status is required. Allowed: Reserved, CheckedIn, CheckedOut, Cancelled.");
            else
            {
                var rs = model.ReservationStatus.Trim();
                if (!(rs.Equals("Reserved", StringComparison.OrdinalIgnoreCase) || rs.Equals("CheckedIn", StringComparison.OrdinalIgnoreCase) || rs.Equals("CheckedOut", StringComparison.OrdinalIgnoreCase) || rs.Equals("Cancelled", StringComparison.OrdinalIgnoreCase)))
                    errors.Add("Reservation status must be one of: Reserved, CheckedIn, CheckedOut, Cancelled.");
            }

            if (!model.CheckInDate.HasValue || !model.CheckOutDate.HasValue)
            {
                errors.Add("Both check-in and check-out dates are required.");
            }
            else
            {
                var checkIn = model.CheckInDate.Value.Date;
                var checkOut = model.CheckOutDate.Value.Date;

                if (checkIn < DateTime.Now.Date)
                    errors.Add("Check-in date cannot be in the past.");

                if (checkOut < checkIn)
                    errors.Add("Check-out date must be after or equal to check-in date.");

                var nights = (checkOut - checkIn).Days;
                if (nights <= 0)
                    errors.Add("Reservation must be at least one night.");

                if (model.TotalPricePerNight < 0)
                    errors.Add("Total price per night must be non-negative.");

                var estimatedTotal = model.TotalPricePerNight * (nights > 0 ? nights : 1);

                if (model.AmountToPay < 0)
                    errors.Add("Amount to pay must be non-negative.");

                if (model.AmountToPay > estimatedTotal)
                    errors.Add("Amount to pay cannot exceed estimated total for the stay (nights * price per night). Estimated total: " + estimatedTotal.ToString("F2"));
            }

            if (string.IsNullOrWhiteSpace(model.PaymentStatus))
                errors.Add("Payment status is required. Example: Full Payment, Partial, Pending");

            var rooms = _roomRepository.GetAllRooms();
            bool roomFound = false;
            if (rooms != null)
            {
                for (int i = 0; i < rooms.Count; i++)
                {
                    var r = rooms[i];
                    if (r == null) continue;
                    if (r.RoomNo.ToString() == model.RoomNumber && string.Equals(r.RoomType, model.RoomType, StringComparison.OrdinalIgnoreCase))
                    {
                        roomFound = true;
                        break;
                    }
                }
            }
            if (!roomFound)
                errors.Add("Selected room does not exist for the chosen type. Refresh room list and try again.");

            if (!string.IsNullOrWhiteSpace(model.RoomType) && !string.IsNullOrWhiteSpace(model.RoomNumber) && model.CheckInDate.HasValue && model.CheckOutDate.HasValue)
            {
                var available = GetAvailableRoomNumbersByType(model.RoomType, model.CheckInDate.Value.Date, model.CheckOutDate.Value.Date);
                bool stillAvailable = false;
                if (available != null)
                {
                    for (int i = 0; i < available.Count; i++)
                    {
                        if (available[i] == model.RoomNumber)
                        {
                            stillAvailable = true;
                            break;
                        }
                    }
                }
                if (!stillAvailable)
                    errors.Add("Selected room is not available for the chosen dates. Choose another room or adjust dates.");
            }

            if (errors.Count > 0)
                return (false, string.Join("\n", errors));

            return (true, string.Empty);
        }

        public int Create(CustomerReservationModel model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            var validation = ValidateReservation(model);
            if (!validation.isValid) throw new ArgumentException(validation.errorMessage);

            return _repository.Create(model);
        }

        public List<CustomerReservationModel> GetAll()
        {
            return _repository.GetAll();
        }

        public List<CustomerReservationModel> GetAllForGrid()
        {
            var result = new List<CustomerReservationModel>();
            var all = _repository.GetAll();
            if (all == null) return result;

            var today = DateTime.Now.Date;
            for (int i = 0; i < all.Count; i++)
            {
                var r = all[i];
                if (r == null) continue;
                if (string.IsNullOrWhiteSpace(r.CustomerName)) continue;
                if (!r.CheckInDate.HasValue || !r.CheckOutDate.HasValue) continue;
                if (!string.IsNullOrWhiteSpace(r.ReservationStatus) && r.ReservationStatus.Equals("Cancelled", StringComparison.OrdinalIgnoreCase)) continue;
                if (r.CheckOutDate.Value.Date < today) continue;

                result.Add(r);
            }

            return result;
        }

        public List<string> GetRoomTypes()
        {
            try
            {
                var rooms = _roomRepository.GetAllRooms();
                var types = new List<string>();

                if (rooms == null) return types;

                for (int i = 0; i < rooms.Count; i++)
                {
                    var r = rooms[i];
                    if (r == null) continue;
                    var rt = r.RoomType;
                    if (string.IsNullOrWhiteSpace(rt)) continue;

                    bool found = false;
                    for (int k = 0; k < types.Count; k++)
                    {
                        if (string.Equals(types[k], rt, StringComparison.OrdinalIgnoreCase))
                        {
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                        types.Add(rt);
                }

                return types;
            }
            catch
            {
                return new List<string>();
            }
        }

        public List<string> GetAvailableRoomNumbersByType(string roomType, DateTime checkIn, DateTime checkOut)
        {
            var result = new List<string>();
            if (string.IsNullOrWhiteSpace(roomType)) return result;
            if (checkOut < checkIn) return result;

            try
            {
                var allRooms = _roomRepository.GetAllRooms();
                if (allRooms == null) return result;

                var reservations = _repository.GetAll();

                for (int i = 0; i < allRooms.Count; i++)
                {
                    var room = allRooms[i];
                    if (room == null) continue;
                    if (!string.Equals(room.RoomType, roomType, StringComparison.OrdinalIgnoreCase)) continue;

                    if (!string.IsNullOrWhiteSpace(room.Status) && !room.Status.Equals("Available", StringComparison.OrdinalIgnoreCase))
                        continue;

                    bool overlapping = false;

                    if (reservations != null)
                    {
                        for (int j = 0; j < reservations.Count; j++)
                        {
                            var r = reservations[j];
                            if (r == null) continue;
                            if (string.IsNullOrWhiteSpace(r.RoomNumber)) continue;
                            if (!string.Equals(r.RoomNumber, room.RoomNo.ToString(), StringComparison.OrdinalIgnoreCase)) continue;

                            if (!string.IsNullOrWhiteSpace(r.ReservationStatus) &&
                                (r.ReservationStatus.Equals("Cancelled", StringComparison.OrdinalIgnoreCase) || r.ReservationStatus.Equals("CheckedOut", StringComparison.OrdinalIgnoreCase)))
                                continue;

                            if (!r.CheckInDate.HasValue || !r.CheckOutDate.HasValue) continue;

                            if (DatesOverlap(r.CheckInDate.Value.Date, r.CheckOutDate.Value.Date, checkIn.Date, checkOut.Date))
                            {
                                overlapping = true;
                                break;
                            }
                        }
                    }

                    if (!overlapping)
                    {
                        result.Add(room.RoomNo.ToString());
                    }
                }

                return result;
            }
            catch
            {
                return new List<string>();
            }
        }

        private bool DatesOverlap(DateTime aStart, DateTime aEnd, DateTime bStart, DateTime bEnd)
        {
            // Treat ranges as [start, end) where 'end' is exclusive (checkout day is not occupied).
            // Two ranges overlap if aStart < bEnd && bStart < aEnd
            return aStart < bEnd && bStart < aEnd;
        }

        public RoomModel GetRoomByRoomNo(string roomNo)
        {
            if (string.IsNullOrWhiteSpace(roomNo)) return null;
            try
            {
                return _roomRepository.GetRoomByRoomNo(roomNo);
            }
            catch
            {
                return null;
            }
       }

        public bool CancelReservation(int reservationId)
        {
            if (reservationId <= 0) throw new ArgumentException("Invalid reservation id");

            var res = _repository.GetById(reservationId);
            if (res == null) return false;

            var ok = _repository.UpdateReservationStatus(reservationId, "Cancelled");

            try
            {
                if (!string.IsNullOrWhiteSpace(res.RoomNumber) && int.TryParse(res.RoomNumber.Trim(), out int rn))
                {
                    var all = _repository.GetAll();
                    var today = DateTime.Now.Date;

                    bool hasToday = false;
                    bool hasFuture = false;

                    if (all != null)
                    {
                        for (int i = 0; i < all.Count; i++)
                        {
                            var r = all[i];
                            if (r == null) continue;
                            if (r.ReservationId == reservationId) continue;
                            if (string.IsNullOrWhiteSpace(r.RoomNumber)) continue;
                            if (!string.Equals(r.RoomNumber, res.RoomNumber, StringComparison.OrdinalIgnoreCase)) continue;
                            if (string.IsNullOrWhiteSpace(r.ReservationStatus)) continue;
                            if (r.ReservationStatus.Equals("Cancelled", StringComparison.OrdinalIgnoreCase) || r.ReservationStatus.Equals("CheckedOut", StringComparison.OrdinalIgnoreCase)) continue;

                            if (r.CheckInDate.HasValue && r.CheckOutDate.HasValue)
                            {
                                var ci = r.CheckInDate.Value.Date;
                                var co = r.CheckOutDate.Value.Date;
                                if (ci <= today && co >= today)
                                {
                                    hasToday = true;
                                    break;
                                }

                                if (ci > today)
                                {
                                    hasFuture = true;
                                }
                            }
                        }
                    }

                    string statusToSet = "Available";
                    if (hasToday) statusToSet = "Occupied";
                    else if (hasFuture) statusToSet = "Reserved";

                    try
                    {
                        _roomRepository.UpdateRoomStatusByRoomNo(rn, statusToSet);
                        try { AppEvents.NotifyRoomStatusChanged(); } catch { }
                    }
                    catch
                    {
                    }
                }
            }
            catch
            {
            }

            return ok;
        }

        public CustomerReservationModel GetById(int reservationId)
        {
            if (reservationId <= 0) return null;
            try
            {
                return _repository.GetById(reservationId);
            }
            catch
            {
                return null;
            }
        }

        public bool CheckInReservation(int reservationId, string paymentStatus, decimal amountPaid, decimal changeDue)
        {
            if (reservationId <= 0) throw new ArgumentException("Invalid reservation id");
            try
            {
                var ok = _repository.UpdateReservationPaymentAndStatus(reservationId, paymentStatus, amountPaid, changeDue);
                if (!ok) return false;

                try
                {
                    var res = _repository.GetById(reservationId);
                    if (res != null && !string.IsNullOrWhiteSpace(res.RoomNumber) && int.TryParse(res.RoomNumber.Trim(), out int rn))
                    {
                        try
                        {
                            _roomRepository.UpdateRoomStatusByRoomNo(rn, "Occupied");
                            try { AppEvents.NotifyRoomStatusChanged(); } catch { }
                        }
                        catch
                        {
                        }
                    }
                }
                catch
                {
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CheckOutReservation(int reservationId, decimal amountPaidNow, decimal damageFee, decimal lateFee)
        {
            if (reservationId <= 0) throw new ArgumentException("Invalid reservation id");
            var res = _repository.GetById(reservationId);
            if (res == null) return false;

            int nights = 1;
            if (res.CheckInDate.HasValue && res.CheckOutDate.HasValue)
            {
                nights = (res.CheckOutDate.Value.Date - res.CheckInDate.Value.Date).Days;
                if (nights < 1) nights = 1;
            }
            decimal roomTotal = res.TotalPricePerNight * nights;
            decimal subtotal = roomTotal * 1;
            decimal total = subtotal + damageFee + lateFee;

            decimal newAmountPaid = res.AmountPaid + amountPaidNow;
            decimal change = newAmountPaid - total;
            if (change < 0) change = 0m;

            var ok = _repository.UpdateReservationPaymentAndStatusWithStatus(reservationId, res.PaymentStatus, newAmountPaid, change, "CheckedOut");
            if (!ok) return false;

            try
            {
                if (!string.IsNullOrWhiteSpace(res.RoomNumber) && int.TryParse(res.RoomNumber.Trim(), out int rn))
                {
                    var all = _repository.GetAll();
                    var today = DateTime.Now.Date;

                    bool hasToday = false;
                    bool hasFuture = false;

                    if (all != null)
                    {
                        for (int i = 0; i < all.Count; i++)
                        {
                            var r = all[i];
                            if (r == null) continue;
                            if (r.ReservationId == reservationId) continue;
                            if (string.IsNullOrWhiteSpace(r.RoomNumber)) continue;
                            if (!string.Equals(r.RoomNumber, res.RoomNumber, StringComparison.OrdinalIgnoreCase)) continue;
                            if (string.IsNullOrWhiteSpace(r.ReservationStatus)) continue;
                            if (r.ReservationStatus.Equals("Cancelled", StringComparison.OrdinalIgnoreCase) || r.ReservationStatus.Equals("CheckedOut", StringComparison.OrdinalIgnoreCase)) continue;

                            if (r.CheckInDate.HasValue && r.CheckOutDate.HasValue)
                            {
                                var ci = r.CheckInDate.Value.Date;
                                var co = r.CheckOutDate.Value.Date;
                                if (ci <= today && co >= today)
                                {
                                    hasToday = true;
                                    break;
                                }

                                if (ci > today)
                                {
                                    hasFuture = true;
                                }
                            }
                        }
                    }

                    string statusToSet = "Available";
                    if (hasToday) statusToSet = "Occupied";
                    else if (hasFuture) statusToSet = "Reserved";

                    try
                    {
                        _roomRepository.UpdateRoomStatusByRoomNo(rn, statusToSet);
                        try { AppEvents.NotifyRoomStatusChanged(); } catch { }
                    }
                    catch
                    {
                    }
                }
            }
            catch
            {
            }

            return true;
        }
#endregion
    }
}
