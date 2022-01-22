using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CommunityPortal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CommunityPortal.ViewModels
{
    public class CreateCategoryViewModel
    {
        [Key] public string Id { get; set; }
        
        [Required] [MaxLength(256)] public string Name { get; set; }
    }
}