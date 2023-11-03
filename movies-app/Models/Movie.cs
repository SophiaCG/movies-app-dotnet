using System;
using System.Collections.Generic;
using Humanizer.Localisation;
using Newtonsoft.Json;

namespace movies_app.Models
{
    public class Result
    {
        public bool Adult { get; set; }
        [JsonProperty("backdrop_path")]
        public string? BackdropPath { get; set; }
        [JsonProperty("genre_ids")]
        public List<int> GenreIds { get; set; } = new List<int>(); // Set to a new list to ensure non-null value
        public int Id { get; set; }
        [JsonProperty("original_language")]
        public string? OriginalLanguage { get; set; }
        [JsonProperty("original_title")]
        public string? OriginalTitle { get; set; }
        public string? Overview { get; set; }
        public double Popularity { get; set; }
        [JsonProperty("poster_path")]
        public string? PosterPath { get; set; }
        [JsonProperty("release_date")]
        public string? ReleaseDate { get; set; }
        public string? Title { get; set; }
        public bool Video { get; set; }
        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }
        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }
        public int? Runtime { get; set; }
        public List<Genre> Genres { get; set; } = new List<Genre>(); // Set to a new list to ensure non-null value
    }

    public class Genre
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    public class Root
    {
        public int Page { get; set; }
        public List<Result> Results { get; set; } = new List<Result>(); // Set to a new list to ensure non-null value
    }
}
