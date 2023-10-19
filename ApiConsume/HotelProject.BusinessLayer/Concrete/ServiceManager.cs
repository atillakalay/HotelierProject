﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ServiceManager : GenericManager<Service>, IServiceService
    {
        public ServiceManager(IGenericDal<Service> genericDal) : base(genericDal)
        {
        }
    }
}
