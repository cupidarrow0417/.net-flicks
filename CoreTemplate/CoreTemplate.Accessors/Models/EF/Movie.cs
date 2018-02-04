﻿using CoreTemplate.Accessors.Models.EF.Base;
using System.Collections.Generic;

namespace CoreTemplate.Accessors.Models.EF
{
    public class Movie : Entity
    {
        public string Name { get; set; }

        public int Year { get; set; }

        public int Runtime { get; set; }

        public string ImageUrl { get; set; }

        public int RentCost { get; set; }

        public int PurchaseCost { get; set; }

        public virtual ICollection<MovieGenre> Genres { get; set; }

        public virtual ICollection<MoviePerson> People { get; set; }
    }
}
