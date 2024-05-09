using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne.Cinema.Storage.Entities
{
    [Table("Movies", Schema = "Cinema")]
    public class Movie
    {
        public Movie(string name, int year, int seanceTime, string description, long categoryId)
        {
            MovieCategoryId = categoryId;
            Name = name;
            Year = year;
            TimeMinutes = seanceTime;
            Description = description;
            IsActive = true;

        }

        [Required]
        [MinLength(3)]
        [MaxLength(128)]
        public string Name { get; set; }

        [Required]
        public long MovieCategoryId { get; set; }

        [Required]
        public int Year { get; set; }

        


        [Required]
        [MinLength(3)]
        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        public int TimeMinutes { get; set; }

        [Required]
        public bool IsActive { get; set; }
        public DateTime ActiveFrom { get; set; }
        public DateTime ActiveTo { get; set; }

        public ICollection<Seance> Seances { get; set; }
        [Required]
        public long Id { get; set; }
    }
}
