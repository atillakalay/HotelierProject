using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concrete
{
    public class MessageCategoryManager : IMessageCategoryService
    {
        private readonly IMessageCategoryDal _messageCategoryDal;

        public MessageCategoryManager(IMessageCategoryDal messageCategoryDal)
        {
            _messageCategoryDal = messageCategoryDal;
        }

        public void Delete(MessageCategory entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _messageCategoryDal.Delete(entity);
        }

        public List<MessageCategory> GetAll()
        {
            return _messageCategoryDal.GetAll();
        }

        public MessageCategory GetByID(int id)
        {
            return _messageCategoryDal.GetById(id);
        }

        public void Insert(MessageCategory entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _messageCategoryDal.Insert(entity);
        }

        public void Update(MessageCategory entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _messageCategoryDal.Update(entity);
        }
    }
}
