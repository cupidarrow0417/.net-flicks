﻿using CoreTemplate.ViewModels.Base;
using CoreTemplate.ViewModels.Movie;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreTemplate.ViewModels.Person
{
    public class PersonViewModel : EntityViewModel
    {
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Death Date (Optional)")]
        public DateTime? DeathDate { get; set; }

        [Url]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }

        public string Age { get; set; }

        public List<MovieViewModel> Movies { get; set; }

        public int MoviesCount { get; set; }

        [Display(Name = "Movies")]
        public string MoviesTooltip { get; set; }
    }
}
