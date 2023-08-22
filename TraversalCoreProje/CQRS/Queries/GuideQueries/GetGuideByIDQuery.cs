using MediatR;
using TraversalCoreProje.CQRS.Results.GuideResults;

namespace TraversalCoreProje.CQRS.Queries.GuideQueries
{
    public class GetGuideByIDQuery : IRequest<GetGuideByIDQueryResult>
    {
        public int ID { get; set; }
        public GetGuideByIDQuery(int id)
        {
            ID = id;
        }
    }
}
