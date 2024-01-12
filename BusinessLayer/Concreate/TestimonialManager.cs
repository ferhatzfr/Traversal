using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class TestimonialManager : ITestimonialService

    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public Testimonial GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> TGetList()
        {
           return _testimonialDal.TGetList();
        }

        public void TUpdate(Testimonial t)
        {
            throw new NotImplementedException();
        }
    }
}
