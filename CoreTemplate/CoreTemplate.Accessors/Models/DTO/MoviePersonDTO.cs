﻿using CoreTemplate.Accessors.Models.DTO.Base;

namespace CoreTemplate.Accessors.Models.DTO
{
    public class MoviePersonDTO : EntityDTO
    {
        public int MovieId { get; set; }

        public MovieDTO Movie { get; set; }

        public int PersonId { get; set; }

        public PersonDTO Person { get; set; }

        public int JobTitleId { get; set; }

        public JobTitleDTO JobTitle { get; set; }
    }
}
