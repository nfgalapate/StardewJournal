using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activities.Commands
{
    public class UpdateActivity : IRequest
    {
        public Activity Activity { get; set; }
    }

    public class UpdateActivityHandler : IRequestHandler<UpdateActivity>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public UpdateActivityHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task Handle(UpdateActivity request, CancellationToken cancellationToken)
        {
            var activity = await _context.Activities.FindAsync(request.Activity.Id);
            _mapper.Map(request.Activity, activity);

            await _context.SaveChangesAsync();
        }
    }
}