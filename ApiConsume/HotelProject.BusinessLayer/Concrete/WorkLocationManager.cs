using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class WorkLocationManager : GenericManager<WorkLocation>, IWorkLocationService
    {
        private readonly IWorkLocationDal _workLocationDal;

        public WorkLocationManager(IGenericDal<WorkLocation> genericDal, IWorkLocationDal workLocationDal)
            : base(genericDal)
        {
            _workLocationDal = workLocationDal;
        }
    }
}
