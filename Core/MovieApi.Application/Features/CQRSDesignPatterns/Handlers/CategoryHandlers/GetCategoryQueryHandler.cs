using Azure.Identity;
using Microsoft.EntityFrameworkCore;
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
    public class GetCategoryQueryHandler(MovieContext _context)
    {

        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var values = await _context.Categories.ToListAsync();
            return values.Select(x => new GetCategoryQueryResult
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName
            }).ToList();
            
        } 
    }
}
