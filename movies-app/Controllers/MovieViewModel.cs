using movies_app.Models;

namespace movies_app.Controllers
{
    internal class MovieViewModel
    {
        public Result Movie { get; set; }
        public Root SimilarMovies { get; set; }
    }
}