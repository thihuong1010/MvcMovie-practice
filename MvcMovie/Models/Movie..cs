﻿using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models;
using System.ComponentModel.DataAnnotations.Schema;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }

    [Display(Name = "Release Date")] // specifies what to display for the name of the field
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
    public string? Rating { get; set; }
}

