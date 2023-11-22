using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewsApp.Themes
{
    public class CreateThemeDto
    {
        [Required]
        public string Name { get; set; }
        public int? Id { get; set; }
         
        public int? ParentId { get; set; }
    }
}
