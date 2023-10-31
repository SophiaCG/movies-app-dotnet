using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace movies_app.Models
{
    public class Result
    {
        public bool Adult { get; set; }
        public string? BackdropPath { get; set; }
        public List<int> GenreIds { get; set; } = new List<int>(); // Set to a new list to ensure non-null value
        public int Id { get; set; }
        public string? OriginalLanguage { get; set; }
        public string? OriginalTitle { get; set; }
        public string? Overview { get; set; }
        public double Popularity { get; set; }
        [JsonProperty("poster_path")]
        public string? PosterPath { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? Title { get; set; }
        public bool Video { get; set; }
        public double VoteAverage { get; set; }
        public int VoteCount { get; set; }
    }

    public class Root
    {
        public int Page { get; set; }
        public List<Result> Results { get; set; } = new List<Result>(); // Set to a new list to ensure non-null value
    }
}
