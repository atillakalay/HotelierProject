using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        private readonly Context _context;
        public EfAppUserDal(Context context) : base(context)
        {
            _context = context;
        }

        public int AppUserCount()
        {
            var value = _context.Users.Count();
            return value;
        }

        public List<AppUser> UserListWithWorkLocation()
        {
            return _context.Users.Include(x => x.WorkLocation).ToList();
        }

        public List<AppUser> UsersListWithWorkLocations()
        {
            var values = _context.Users.ToList();
            return values.ToList();
        }
    }
}
