using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPatterns.Comands.TagCommands
{
    public class CreateTagCommand: IRequest
    {
        public string Title { get; set; }
    }
}
