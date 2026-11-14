using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands
{
    public class CreateCategoryCommand
    {
        public string CategoryName { get; set; }
    }
}
