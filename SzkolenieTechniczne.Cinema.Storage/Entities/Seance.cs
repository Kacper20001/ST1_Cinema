using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne.Cinema.Storage.Entities
{
    [Table("Seances", Schema = "Cinema")]

    
    public class Seance
    {
        public Seance(DateTime date, long movieId, int numberOfTickets) 
        {
            Date = date;
            MovieId = movieId;
            NumberOfTickets = numberOfTickets;
        }
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int NumberOfTickets { get; set; }

        [Required]
        public long MovieId { get; set; }

        [Required]
        public Movie Movie { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
        [Required]
        public long Id { get; set; }
    }
}
