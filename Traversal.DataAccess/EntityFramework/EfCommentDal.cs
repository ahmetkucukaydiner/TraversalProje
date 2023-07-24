﻿using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Repository;
using Traversal.Entities.Concrete;

namespace Traversal.DataAccess.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
    }
}
