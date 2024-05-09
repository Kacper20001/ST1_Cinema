using Microsoft.AspNetCore.Mvc;
using SzkolenieTechniczne.Cinema.Service.Command.Movie.Add;
using SzkolenieTechniczne.Cinema.Service.Query.Dtos;
using SzkolenieTechniczne.Cinema.Storage.Entities;

namespace SzkolenieTechniczne.Cinemaa.Controllers
{
    public class MovieController : Controller

    {
        private static List<SzkolenieTechniczne.Cinema.Service.Query.Dtos.MovieDto> _movies =
                new List<SzkolenieTechniczne.Cinema.Service.Query.Dtos.MovieDto>()
                { 
                    new MovieDto("Terminator",1),
                    new MovieDto("Dexter",2),
                    new MovieDto("Bolek i Lolek",3),
                };
        public MovieController() { 
        }

        public IActionResult Index()
        {
            return View(_movies);
        }
        public IActionResult Edit(long id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(long id)
        {
            return RedirectToAction("Index");
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddMovieCommand command)
        {
            _movies.Add(new MovieDto(command.Name, 0));
            return RedirectToAction("Index");
        }


        

    }
}
