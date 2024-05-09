using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne.Cinema.Service.Command.Movie.Seance.RegisterSeance
{
    public class RegisterSeanceCommandValidator : AbstractValidator<RegisterSeanceCommand>
    {
        public RegisterSeanceCommandValidator() 
        {
            RuleFor(x => x.MovieId).NotEmpty();
            RuleFor(x => x.NumberOfTickets).NotEmpty().GreaterThan(1);
            RuleFor(x => x.SeanceDate).NotEmpty().GreaterThan(DateTime.UtcNow);
        }
    }
}
