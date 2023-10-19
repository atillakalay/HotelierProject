using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        private readonly Context _context;

        public EfBookingDal(Context context) : base(context)
        {
            _context = context;
        }

        public void BookingStatusChangeApproved(Booking booking)
        {
            var values = _context.Bookings.Where(x => x.BookingID == booking.BookingID).FirstOrDefault();
            values.Status = "Onaylandı";
            _context.SaveChanges();
        }

        public void BookingStatusChangeApproved2(int id)
        {
            var values = _context.Bookings.Find(id);
            values.Status = "Onaylandı";
            _context.SaveChanges();
        }

        public void BookingStatusChangeApproved3(int id)
        {
            var values = _context.Bookings.Find(id);
            values.Status = "Onaylandı";
            _context.SaveChanges();
        }

        public void BookingStatusChangeCancel(int id)
        {
            var values = _context.Bookings.Find(id);
            values.Status = "İptal Edildi";
            _context.SaveChanges();
        }

        public void BookingStatusChangeWait(int id)
        {
            var values = _context.Bookings.Find(id);
            values.Status = "Müşteri Aranacak";
            _context.SaveChanges();
        }

        public int GetBookingCount()
        {
            var value = _context.Bookings.Count();
            return value;
        }

        public List<Booking> Last6Bookings()
        {
            var values = _context.Bookings.OrderByDescending(x => x.BookingID).Take(6).ToList();
            return values;
        }
    }
}
