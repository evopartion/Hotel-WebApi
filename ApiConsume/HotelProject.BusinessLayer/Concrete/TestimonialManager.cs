using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;
        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }
        public void TDelete(EntityLayer.Concrete.Testimonial t)
        {
            _testimonialDal.Delete(t);
        }

        public EntityLayer.Concrete.Testimonial TGetByID(int id)
        {
            return _testimonialDal.GetByID(id);
        }

        public List<EntityLayer.Concrete.Testimonial> TGetList()
        {
            return _testimonialDal.GetList();
        }

        public void TInsert(EntityLayer.Concrete.Testimonial t)
        {
            _testimonialDal.Insert(t);
        }

        public void TUpdate(EntityLayer.Concrete.Testimonial t)
        {
            _testimonialDal.Update(t);
        }
    }
}
