using System;
using System.Collections.Generic;

namespace movies_app.Models
{
    public class GenreMapper
    {
        public static Dictionary<int, string> genreMapping = new Dictionary<int, string>()
        {
            { 28, "Action" },
            { 12, "Adventure" },
            { 16, "Animation" },
            { 35, "Comedy" },
            { 80, "Crime" },
            { 99, "Documentary" },
            { 18, "Drama" },
            { 10751, "Family" },
            { 14, "Fantasy" },
            { 36, "History" },
            { 27, "Horror" },
            { 10402, "Music" },
            { 9648, "Mystery" },
            { 10749, "Romance" },
            { 878, "Science Fiction" },
            { 10770, "TV Movie" },
            { 53, "Thriller" },
            { 10752, "War" },
            { 37, "Western" }
        };

        public static string GetGenres(List<int> genreIds)
        {
            List<string> genres = new List<string>();
            foreach (var genreId in genreIds)
            {
                if (genreMapping.ContainsKey(genreId))
                {
                    genres.Add(genreMapping[genreId]);
                }
            }
            return string.Join(", ", genres);
        }
    }
}
