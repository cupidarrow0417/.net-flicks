﻿using CoreTemplate.ViewModels.Base;
using System.ComponentModel.DataAnnotations;

namespace CoreTemplate.ViewModels.Movie
{
    public class MovieViewModel : EntityViewModel
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public int Runtime { get; set; }

        [Required]
        public int Year { get; set; }
    }
}
