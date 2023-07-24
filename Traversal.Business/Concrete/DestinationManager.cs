﻿using System.Linq.Expressions;
using Traversal.Business.Abstract;
using Traversal.DataAccess.Abstract;
using Traversal.Entities.Concrete;

namespace Traversal.Business.Concrete
{
    public class DestinationManager : IDestinationService
    {
        private readonly IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void TAdd(Destination entity)
        {
            _destinationDal.Add(entity);
        }

        public void TDelete(Destination entity)
        {
            _destinationDal.Delete(entity);
        }

        public void TUpdate(Destination entity)
        {
            _destinationDal.Update(entity);
        }

        public List<Destination> TGetList(Expression<Func<Destination, bool>> filter = null)
        {
            return _destinationDal.GetList();
        }

        public Destination TGetByID(int id)
        {
            return _destinationDal.Get(x => x.Id == id);
        }
    }
}
