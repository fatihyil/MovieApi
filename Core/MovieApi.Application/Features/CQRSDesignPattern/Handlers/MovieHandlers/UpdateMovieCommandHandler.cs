using MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class UpdateMovieCommandHandler
    {
        private readonly MovieContext _context;

        public UpdateMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async void Handler(UpdateMovieCommand command)
        {
            var movie =  await _context.Movies.FindAsync(command.MovieId);
            movie.Title = command.Title;
            movie.CoverImgUrl = command.CoverImgUrl;
            movie.Rating = command.Rating;
            movie.Description = command.Description;
            movie.Duration = command.Duration;
            movie.ReleaseDate = command.ReleaseDate;
            movie.CreatedYear = command.CreatedYear;
            movie.Status = command.Status;

            //_context.Movies.Update(movie);
            await _context.SaveChangesAsync();
        }
    }
}
