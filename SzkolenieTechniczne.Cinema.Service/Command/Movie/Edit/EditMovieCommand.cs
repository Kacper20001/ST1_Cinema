using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne.Cinema.Service.Command.Movie.Edit
{
    public class EditMovieCommand : ICommand
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int TimeMinutes { get; set; }

    }
}
