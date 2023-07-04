namespace AspNetCoreTemplate.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using AspNetCoreTemplate.Data.Common.Models;

    using static AspNetCoreTemplate.Data.Common.GlobalConstants.Category;

    public class Category : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        public List<SubCategory> SubCategories { get; set; } = new List<SubCategory>(); // TODO: do i have to instantiate this? wtf?? do it w/o
    }
}