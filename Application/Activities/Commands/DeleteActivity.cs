using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Activities.Commands
{
    public class DeleteActivity : IRequest
    {
        public Guid Id {get; set;}

        public class DeleteActivityHandler : IRequestHandler<DeleteActivity>
        {
        public DataContext _context { get; }
            public DeleteActivityHandler(DataContext context)
            {
                _context = context;
            }
            public async Task Handle(DeleteActivity request, CancellationToken cancellationToken)
            {
                var activity = await _context.Activities.FindAsync(request.Id);
                _context.Remove(activity);

                await _context.SaveChangesAsync();
            }
        }
    }
}