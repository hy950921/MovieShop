﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class ReviewResponseModel
    {
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public decimal? Rating { get; set; }
        public string Review { get; set; }
    }
}
