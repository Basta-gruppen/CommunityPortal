﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPortal.Models
{
    public class PostTag
    {
        [Required]
        public string PostId { get; set; }

        [Required]
        public string TagId { get; set; }

        public Post Post { get; set; }
        public Tag Tag { get; set; }
    }
}
