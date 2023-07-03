using System.Collections.Concurrent;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace MvcMovie.Models
{
	public class MovieGereViewModel
	{
		public List<Movie>? Movies { get; set; } // List of movies
		public SelectList? Genres { get; set; } // Contain list of genres
		public string? MovieGenre { get; set; } // The selected genre
		public string? SearchString { get; set; } // User input
	}
}

