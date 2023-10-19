using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class SubscribeManager : GenericManager<Subscribe>, ISubscribeService
    {
        private readonly ISubscribeDal _subscribeDal;

        public SubscribeManager(IGenericDal<Subscribe> genericDal, ISubscribeDal subscribeDal)
            : base(genericDal)
        {
            _subscribeDal = subscribeDal;
        }
    }
}
