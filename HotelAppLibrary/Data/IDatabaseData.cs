using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAppLibrary.Databases;
using HotelAppLibrary.Models;

namespace HotelAppLibrary.Data
{
    public interface IDatabaseData
    {

        public List<RoomTypeModel> GetAvailableRoomTypes(DateTime startDate, DateTime endDate);


        public void BookGuest(string firstName,
            string lastName,
            DateTime startDate,
            DateTime endDate,
            int roomTypeId);




        List<BookingFullModel> SearchBookings(string lastName);

        public void CheckInGuest(int bookingId);
        public RoomTypeModel GetRoomTypeById(int id);

    }

}
