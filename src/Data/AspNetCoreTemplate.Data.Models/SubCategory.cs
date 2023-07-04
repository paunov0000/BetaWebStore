﻿namespace AspNetCoreTemplate.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class SubCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required] 
        public List<Category> Categories { get; set; } = new List<Category>(); 
    }
}
