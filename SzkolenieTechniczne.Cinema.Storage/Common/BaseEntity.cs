using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne.Cinema.Storage.Common
{
    public class BaseEntity
    {
        [Key]
        public long ID { get; set; }
    }
}
