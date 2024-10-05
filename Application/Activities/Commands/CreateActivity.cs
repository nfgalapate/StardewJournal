using Domain;
using MediatR;
using Persistence;

namespace Application.Activities.Commands
{
    public class CreateActivity : IRequest
    {
        public Activity Activity { get; set; }

        public class CreateActivityHandler : IRequestHandler<CreateActivity>
        {
            private readonly DataContext _context;
            public CreateActivityHandler(DataContext context)
            {
                _context = context;
            }
            public async Task Handle(CreateActivity request, CancellationToken cancellationToken)
            {
                _context.Activities.Add(request.Activity);
                await _context.SaveChangesAsync();
            }
        }
    }

}