using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationBelmin.Core;
using DataBelmin;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ApplicationBelmin.Activities
{
    public class List
    {
        public class Query : IRequest<Result<List<Activity>>>
        {

        }

        public class Handler : IRequestHandler<Query, Result<List<Activity>>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Result<List<Activity>>> Handle(Query request, CancellationToken cancellationToken)
            {
                return Result<List<Activity>>.Success(await _context.Activities.OrderBy(x => x.Date).ToListAsync(cancellationToken));
            }
        }
    }
}