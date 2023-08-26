﻿using Traversal.Entities.Concrete;

namespace Traversal.DataAccess.Abstract
{
    public interface IDestinationDal : IGenericDal<Destination>
    {
        public Destination GetDestinationWithGuide(int id);
    }
}
