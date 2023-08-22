namespace TraversalCoreProje.CQRS.Queries.DestinationQueries
{
    public class GetDestinationByIdQuery
    {
        public GetDestinationByIdQuery(int id)
        {
            this.ID = id;
        }
        public int ID { get; set; }


    }
}
