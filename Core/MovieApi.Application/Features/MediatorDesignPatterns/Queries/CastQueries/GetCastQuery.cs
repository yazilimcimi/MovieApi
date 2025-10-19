using MediatR;
using MovieApi.Application.Features.MediatorDesignPatterns.Results.CastResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPatterns.Queries.CastQueries
{
    public class GetCastQuery: IRequest<List<GetCastQueryResult>>
    {
    }
}
