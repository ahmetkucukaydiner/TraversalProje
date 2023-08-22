using Microsoft.EntityFrameworkCore;
using Traversal.DataAccess.Concrete;
using TraversalCoreProje.CQRS.Results.DestinationResults;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {
        private readonly Context _context;
        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _context.Destinations.Select(x => new GetAllDestinationQueryResult
            {
                Id = x.Id,
                City = x.City,
                Capacity = x.Capacity,
                DayNight = x.DayNight,
                Price = x.Price
            }).AsNoTracking().ToList();

            return values;
        }
    }
}
