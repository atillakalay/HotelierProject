﻿using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System.Linq;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfSendMessageDal : GenericRepository<SendMessage>, ISendMessageDal
    {
        private readonly Context _context;

        public EfSendMessageDal(Context context) : base(context)
        {
            _context = context;
        }

        public int GetSendMessageCount()
        {
            return _context.SendMessages.Count();
        }
    }
}
