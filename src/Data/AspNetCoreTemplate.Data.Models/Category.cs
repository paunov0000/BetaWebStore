namespace AspNetCoreTemplate.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public List<SubCategory> SubCategories { get; set; } = new List<SubCategory>(); 
    }
}