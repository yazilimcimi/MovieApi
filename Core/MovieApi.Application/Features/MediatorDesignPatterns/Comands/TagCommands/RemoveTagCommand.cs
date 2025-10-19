using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPatterns.Comands.TagCommands
{
    public class RemoveTagCommand: IRequest
    {
        public int TagId;

        public RemoveTagCommand(int tagId)
        {
            TagId = tagId;
        }

    }
}
