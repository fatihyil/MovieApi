using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApi.Application.Features.CQRSDesignPattern.Queries.MovieQueries
{
    public class GetMovieByIdQuery
    {
        public int MovieId { get; set; }    
    }
}
