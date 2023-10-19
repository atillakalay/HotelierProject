using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System.Linq;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfRoomDal : GenericRepository<Room>, IRoomDal
    {
        private readonly Context _context;

        public EfRoomDal(Context context) : base(context)
        {
            _context = context;
        }

        public int RoomCount()
        {
            var value = _context.Rooms.Count();
            return value;
        }
    }
}
