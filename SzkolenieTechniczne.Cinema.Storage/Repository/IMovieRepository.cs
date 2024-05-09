using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne.Cinema.Storage.Repository
{
    public interface IMovieRepository
    {
        List<Entities.Movie> GetMovies();

        Entities.Movie GetMovieById(long movieId);

        void AddMovie(Entities.Movie movie);
        void RemoveMovie(long id);

        void EditMovie(Entities.Movie movie);

        bool IsMovieExist(long movieId);
        bool IsMovieExist(string name, int year);
        bool IsSeanceExist(DateTime date);

        void AddSeance(Entities.Seance seance);

        List<Entities.Seance> GetSeanceByMovieId(long movieId);

        Entities.Movie GetSeanceDetails(long movieId);
    }
}
