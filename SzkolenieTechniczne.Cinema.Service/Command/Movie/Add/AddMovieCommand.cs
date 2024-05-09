using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne.Cinema.Service.Command.Movie.Add
{
    public sealed class AddMovieCommand : ICommand
    {
        public long CategoryId { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int SeanceTime { get; set; }
        public string Description { get; set; }

    }
}
