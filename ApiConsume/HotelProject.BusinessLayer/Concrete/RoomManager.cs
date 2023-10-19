using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class RoomManager : GenericManager<Room>, IRoomService
    {
        public RoomManager(IGenericDal<Room> genericDal) : base(genericDal)
        {
        }

        public int TRoomCount()
        {
            return GetAll().Count; // Room entity için GetAll metodunu kullanabilirsiniz.
        }
    }
}
