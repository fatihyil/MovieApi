using MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class RemoveMovieCommandHandler
    {
        private readonly MovieContext _context;

        public RemoveMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async void Handler(RemoveMovieCommand command)
        {
            var movies = await _context.Movies.FindAsync(command.MovieId);
            _context.Movies.Remove(movies);
            _context.SaveChangesAsync();

        }
    }
}
