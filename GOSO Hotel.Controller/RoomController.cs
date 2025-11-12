using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GOSO_Hotel.Model;
using GOSO_Hotel.Repository;

namespace GOSO_Hotel.Controller
{
    public class RoomController
    {
        private RoomRepository _roomRepository;

        public RoomController()
        {
            this._roomRepository = new RoomRepository();
        }

        public RoomModel CreateRoom(int roomNumber, string roomType, decimal pricePerNight, int capacity, int numberOfBeds)
        {
            try
            {
                if (roomNumber <= 0)
                    throw new Exception("Room number must be greater than 0.");
                if (string.IsNullOrEmpty(roomType))
                    throw new Exception("Room type cannot be empty.");
                if (pricePerNight <= 0)
                    throw new Exception("Price must be greater than 0.");
                if (capacity <= 0)
                    throw new Exception("Capacity must be greater than 0.");
                if (numberOfBeds <= 0)
                    throw new Exception("Number of beds must be greater than 0.");

                RoomModel newRoom = new RoomModel
                {
                    RoomNo = roomNumber,
                    RoomType = roomType,
                    PricePerNight = pricePerNight,
                    Capacity = capacity,
                    NoOfBeds = numberOfBeds,
                    Status = "Available",
                    CreatedDate = DateTime.Now
                };

                return _roomRepository.CreateRoom(newRoom);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating room: {ex.Message}");
                throw;
            }
        }

        public RoomModel GetRoomById(int roomId)
        {
            try
            {
                if (roomId <= 0)
                    throw new Exception("Invalid room ID.");

                return _roomRepository.GetRoomById(roomId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving room: {ex.Message}");
                throw;
            }
        }

        public List<RoomModel> GetAllRooms()
        {
            try
            {
                return _roomRepository.GetAllRooms();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving rooms: {ex.Message}");
                throw;
            }
        }

        public RoomModel GetRoomByRoomNo(string roomNo)
        {
            return _roomRepository.GetRoomByRoomNo(roomNo);
        }


        public RoomModel UpdateRoom(int roomId, int roomNumber, string roomType, decimal pricePerNight, int capacity, int numberOfBeds, string status)
        {
            try
            {
                if (roomId <= 0)
                    throw new Exception("Invalid room ID.");
                if (roomNumber <= 0 || string.IsNullOrEmpty(roomType) || pricePerNight <= 0 || capacity <= 0 || numberOfBeds <= 0)
                    throw new Exception("Invalid room data.");

                RoomModel updatedRoom = new RoomModel
                {
                    Id = roomId,
                    RoomNo = roomNumber,
                    RoomType = roomType,
                    PricePerNight = pricePerNight,
                    Capacity = capacity,
                    NoOfBeds = numberOfBeds,
                    Status = status,
                    ModifiedDate = DateTime.Now
                };

                return _roomRepository.UpdateRoom(updatedRoom);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating room: {ex.Message}");
                throw;
            }
        }

        public bool DeleteRoomByNumber(int roomNo)
        {
            return _roomRepository.DeleteRoomByNumber(roomNo);
        }

    }
}


