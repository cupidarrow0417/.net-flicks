﻿using CoreTemplate.Accessors.Models.EF.Base;
using System;

namespace CoreTemplate.Accessors.Models.EF
{
    public class CastMember : Entity
    {
        public int MovieId { get; set; }

        public virtual Movie Movie { get; set; }

        public int PersonId { get; set; }

        public virtual Person Person { get; set; }

        public string Role { get; set; }

        public TimeSpan ScreenTime { get; set; }
    }
}
