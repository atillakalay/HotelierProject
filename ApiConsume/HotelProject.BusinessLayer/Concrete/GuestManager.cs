using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
    public class GuestManager : IGuestService
    {
        private readonly IGuestDal _guestDal;

        public GuestManager(IGuestDal guestDal)
        {
            _guestDal = guestDal;
        }

        public void Delete(Guest entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _guestDal.Delete(entity);
        }

        public List<Guest> GetAll()
        {
            return _guestDal.GetAll();
        }

        public Guest GetByID(int id)
        {
            return _guestDal.GetById(id);
        }

        public void Insert(Guest entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _guestDal.Insert(entity);
        }

        public void Update(Guest entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _guestDal.Update(entity);
        }
    }
}
