using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Features.CQRSDesignPatterns.Results.MovieResults;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MovieApi.Application.Features.CQRSDesignPatterns.Handlers.MovieHandlers
{
    public class GetMovieQueryHandler(MovieContext _context)
    {
        public async Task<List<GetMovieQueryResult>> Handle() 
        {
            var values = await _context.Movies.ToListAsync();
            return  values.Select(x => new GetMovieQueryResult
            {
                MovieId = x.MovieId,
                Title = x.Title,
                CoverImageUrl = x.CoverImageUrl,
                Rating = x.Rating,
                Description = x.Description,
                Duration = x.Duration,
                ReleaseDate = x.ReleaseDate,
                CreatedYear = x.CreatedYear,
                Status = x.Status
            }).ToList();
        
        }
    }
}
