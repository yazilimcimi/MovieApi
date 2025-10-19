using MovieApi.Application.Features.CQRSDesignPatterns.Queries.CategoryQueries;
using MovieApi.Application.Features.CQRSDesignPatterns.Results.CategoryResults;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPatterns.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler(MovieContext _context)
    {
        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
        {
            var value = await _context.Categories.FindAsync(query.CategoryId);
            return new GetCategoryByIdQueryResult
            {
                CategoryId = value.CategoryId,
                CategoryName = value.CategoryName
            };
        }
    }
}
