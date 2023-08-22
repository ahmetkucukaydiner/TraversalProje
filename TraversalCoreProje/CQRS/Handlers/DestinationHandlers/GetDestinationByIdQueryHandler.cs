using Traversal.DataAccess.Concrete;
using TraversalCoreProje.CQRS.Queries.DestinationQueries;
using TraversalCoreProje.CQRS.Results.DestinationResults;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetDestinationByIdQueryResult Handle(GetDestinationByIdQuery getDestinationByIdQuery)
        {
            var values = _context.Destinations.Find(getDestinationByIdQuery.ID);
            return new GetDestinationByIdQueryResult
            {
                DestinationId = values.Id,
                City = values.City,
                DayNight = values.DayNight
            };
        }
    }
}
