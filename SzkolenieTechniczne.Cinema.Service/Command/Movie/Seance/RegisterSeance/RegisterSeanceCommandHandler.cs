using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Cinema.Storage.Repository;
using Entities = SzkolenieTechniczne.Cinema.Storage.Entities;

namespace SzkolenieTechniczne.Cinema.Service.Command.Movie.Seance.RegisterSeance
{
    public class RegisterSeanceCommandHandler : ICommandHandler<RegisterSeanceCommand>
    {
        private readonly IMovieRepository _repository;
        public RegisterSeanceCommandHandler(IMovieRepository repository)
        {
            _repository = repository;
        }
        public Result Handle(RegisterSeanceCommand command)
        {
            var validationResult = new RegisterSeanceCommandValidator().Validate(command);
            if (validationResult.IsValid == false)
            {
                return Result.Fail(validationResult);
            }

            var isSeanceExist = _repository.IsSeanceExist(command.SeanceDate);
            if (isSeanceExist)
            {
                return Result.Fail("This seance akready exist");
            }
            var movie = _repository.GetMovieById(command.MovieId);
            if (movie == null)
            {
                return Result.Fail("This movie does not exist");
            }
            var seance = new Entities.Seance(command.SeanceDate, command.MovieId, command.NumberOfTickets);
            movie.Seances.Add(seance);
            return Result.Ok();
        }
    }
}
