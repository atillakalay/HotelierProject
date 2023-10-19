using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class TestimonialManager : GenericManager<Testimonial>, ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(IGenericDal<Testimonial> genericDal, ITestimonialDal testimonialDal)
            : base(genericDal)
        {
            _testimonialDal = testimonialDal;
        }
    }
}
