using MovieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class UpdateCommandCategoryHandler
    {
        private readonly MovieContext _context;

        public UpdateCommandCategoryHandler(MovieContext context)
        {
            _context = context;
        }

        public async void Handler(UpdateCategoryCommand command)
        {
            var category = await _context.Categories.FindAsync(command.CategoryId);
            category.CategoryName = command.CategoryName;
            //_context.Categories.Update(category);
            await _context.SaveChangesAsync();
        }


    }
}
