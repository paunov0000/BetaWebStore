namespace AspNetCoreTemplate.Data.Models
{
    using AspNetCoreTemplate.Data.Common.Models;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static AspNetCoreTemplate.Data.Common.GlobalConstants.IndividualProduct;

    public class IndividualProduct : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        public bool IsOnSale { get; set; }

        [Required]
        public string ProductImageURL { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

        [ForeignKey(nameof(SubCategory))]
        public int SubCategoryId { get; set; }

        public SubCategory SubCategory { get; set; }
    }
}
