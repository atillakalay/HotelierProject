using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
    public class StaffManager : GenericManager<Staff>, IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IGenericDal<Staff> genericDal, IStaffDal staffDal)
            : base(genericDal)
        {
            _staffDal = staffDal;
        }

        public int TGetStaffCount()
        {
            return _staffDal.GetStaffCount();
        }

        public List<Staff> TLast4Staff()
        {
            return _staffDal.Last4Staff();
        }
    }
}
