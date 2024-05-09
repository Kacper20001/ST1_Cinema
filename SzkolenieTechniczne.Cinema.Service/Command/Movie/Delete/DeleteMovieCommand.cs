using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne.Cinema.Service.Command.Movie.Delete
{
    public sealed class DeleteMovieCommand : ICommand
    {
        public DeleteMovieCommand(long id) 
        {
            Id = Id;
        }
        public long Id { get; }
    }
}
