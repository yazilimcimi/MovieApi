﻿using MovieApi.Application.Features.CQRSDesignPatterns.Commands.MovieCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPatterns.Handlers.MovieHandlers
{
    public class CreateMovieCommandHandler
    {
        private readonly MovieContext _context;
        public CreateMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async void handle(CreateMovieCommand command)
        {
            _context.Movies.Add(new Movie
            {
                Title = command.Title,
                CoverImageUrl = command.CoverImageUrl,
                Rating = command.Rating,
                Description = command.Description,
                Duration = command.Duration,
                ReleaseDate = command.ReleaseDate,
                CreatedYear = command.CreatedYear,
                Status = command.Status
            });
            await    _context.SaveChangesAsync();
        }
    }
}
