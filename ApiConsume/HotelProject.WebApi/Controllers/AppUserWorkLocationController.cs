using HotelProject.DataAccessLayer.Concrete;
using HotelProject.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Linq;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserWorkLocationController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IOptions<DbContextOptions<Context>> _contextOptions;

        public AppUserWorkLocationController(IConfiguration configuration, IOptions<DbContextOptions<Context>> contextOptions)
        {
            _configuration = configuration;
            _contextOptions = contextOptions;
        }

        [HttpGet]
        public IActionResult Index()
        {
            using var context = new Context(_contextOptions.Value, _configuration);

            var values = context.Users.Include(x => x.WorkLocation).Select(y => new AppUserWorkLocationViewModel
            {
                Name = y.Name,
                Surname = y.Surname,
                WorkLocationID = y.WorkLocationID,
                WorkLocationName = y.WorkLocation.WorkLocationName,
                City = y.City,
                Country = y.Country,
                Gender = y.Gender,
                ImageUrl = y.ImageUrl
            }).ToList();
            return Ok(values);
        }
    }
}
