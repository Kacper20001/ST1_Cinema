using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Service.Query.Dtos;
using SzkolenieTechniczne.Cinema.Storage.Repository;

namespace SzkolenieTechniczne.Cinema.Service.Query.Movie
{
    public sealed class GetAllMovieQueryHandler : IQueryHandler<GetAllMovieQuery, List<MovieDto>>
    {
        private readonly IMovieRepository _repository;
        public GetAllMovieQueryHandler(IMovieRepository repository)
        {
            _repository = repository;
        }

        public List<MovieDto> Handle(GetAllMovieQuery query)
        {
            var movies = _repository.GetMovies();

            return movies.Select(item => new MovieDto(item.Name,item.Id)).ToList();
        }
    }
}
