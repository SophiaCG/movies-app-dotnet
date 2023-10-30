using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace movies_app.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string PosterUrl { get; set; }
        public int Runtime { get; set; }
    }
}