﻿using CoreTemplate.Accessors.Models.EF.Base;
using System.Collections.Generic;

namespace CoreTemplate.Accessors.Models.EF
{
    public class Person : Entity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<MoviePerson> Movies { get; set; }
    }
}