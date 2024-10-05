using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;
using SQLitePCL;

namespace Application.Activities
{
    public class GetActivityById : IRequest<Activity>
    {
        public Guid Id { get; set;}

        public class GetActivityByIdHandler : IRequestHandler<GetActivityById, Activity>
        {   
            private readonly DataContext _context;
            public GetActivityByIdHandler(DataContext context)
            {
                _context = context;
            }

            public async Task<Activity> Handle(GetActivityById message, CancellationToken cancellationToken)
            {
                return await _context.Activities.FindAsync(message.Id, cancellationToken);
            }
        }
    }
}