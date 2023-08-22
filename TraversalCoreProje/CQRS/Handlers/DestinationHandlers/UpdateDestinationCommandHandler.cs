using Traversal.DataAccess.Concrete;
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;

        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateDestinationCommand updateDestinationCommand)
        {
            var values = _context.Destinations.Find(updateDestinationCommand.DestinationId);
            values.City = updateDestinationCommand.City;
            values.DayNight = updateDestinationCommand.DayNight;
            values.Price = updateDestinationCommand.Price;
            _context.SaveChanges();
        }
    }
}
