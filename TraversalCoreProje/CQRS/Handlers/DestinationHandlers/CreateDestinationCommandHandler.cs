using Traversal.DataAccess.Concrete;
using Traversal.Entities.Concrete;
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly Context _context;

        public CreateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateDestinationCommand createDestinationCommand)
        {
            _context.Destinations.Add(new Destination
            {
                City = createDestinationCommand.City,
                Price = createDestinationCommand.Price,
                Capacity = createDestinationCommand.Capacity,
                DayNight = createDestinationCommand.DayNight,
                Status = true
            });

            _context.SaveChanges();
        }
    }
}
