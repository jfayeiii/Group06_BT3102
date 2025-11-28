using System;

namespace GOSO_Hotel.Controller
{
    public static class AppEvents
    {
        // Raised when any room's status changes (Available/Occupied/Reserved/Out of Service)
        public static event Action OnRoomStatusChanged;

        public static void NotifyRoomStatusChanged()
        {
            try
            {
                OnRoomStatusChanged?.Invoke();
            }
            catch
            {
                // swallow exceptions from subscribers
            }
        }
    }
}
