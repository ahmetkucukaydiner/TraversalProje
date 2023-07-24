using System.Linq.Expressions;
using Traversal.Business.Abstract;
using Traversal.DataAccess.Abstract;
using Traversal.Entities.Concrete;

namespace Traversal.Business.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TAdd(Testimonial entity)
        {
            _testimonialDal.Add(entity);
        }

        public void TDelete(Testimonial entity)
        {
            _testimonialDal.Delete(entity);
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonialDal.Update(entity);
        }

        public List<Testimonial> TGetList(Expression<Func<Testimonial, bool>> filter = null)
        {
            return _testimonialDal.GetList();
        }

        public Testimonial TGetByID(int id)
        {
            return _testimonialDal.Get(x => x.Id == id);
        }
    }
}
