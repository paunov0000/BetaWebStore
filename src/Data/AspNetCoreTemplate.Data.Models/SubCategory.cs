namespace AspNetCoreTemplate.Data.Models
{
    using AspNetCoreTemplate.Data.Common.Models;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static AspNetCoreTemplate.Data.Common.GlobalConstants.SubCategory;

    public class SubCategory : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        public string SubCategoryImageURL { get; set; }

        [Required]
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }

        public int CategoryId { get; set; }
    }
}
