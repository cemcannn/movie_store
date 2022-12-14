using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Movie
{
    public class MovieInsertRequest
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; } 
        public int DirectorId { get; set; }
        public int Price { get; set; }
    }
}
