using MediatR;
using MovieApi.Application.Features.MediatorDesignPatterns.Comands.CastCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPatterns.Handlers.CastHandlers
{
    public class UpdateCastCommandHandler : IRequestHandler<UpdateCastCommand>
    {
        private readonly MovieContext _context;

        public UpdateCastCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateCastCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Casts.FindAsync(request.CastId);

            value.Biography = request.Biography;
            value.ImageUrl = request.ImageUrl;
            value.Name = request.Name;
            value.Overview = request.Overview;
            value.Surname = request.Surname;
            value.Title = request.Title;
            await _context.SaveChangesAsync();
            
        }
    }
}
