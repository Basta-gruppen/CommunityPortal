﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPortal.Models
{
    public class UserGroup
    {
        [Required]
        public string GroupId { get; set; }
        [Required]
        public string UserId { get; set; }
        public Group Group { get; set; }

        public ApplicationUser User { get; set; }
    }
}
