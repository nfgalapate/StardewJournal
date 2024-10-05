using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Activities
{
    public class GetAllActivities : IRequest<List<Activity>>
    {
        public class Handler : IRequestHandler<GetAllActivities, List<Activity>>
        {
            private readonly DataContext _context;    
            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<List<Activity>> Handle(GetAllActivities request, CancellationToken cancellationToken)
            {
                return await _context.Activities.ToListAsync();
            }
        }
    }
}