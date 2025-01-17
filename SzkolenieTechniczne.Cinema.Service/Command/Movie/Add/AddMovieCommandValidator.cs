﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne.Cinema.Service.Command.Movie.Add
{
    public class AddMovieCommandValidator : AbstractValidator<AddMovieCommand>
    {
        public AddMovieCommandValidator() 
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Year).InclusiveBetween(1900, 2040);
            RuleFor(x => x.SeanceTime).InclusiveBetween(30, 300);
        }

    }
}
