namespace AspNetCoreTemplate.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class IndividualProduct
    {
        [Key]
        public int Id { get; set; }

        [Required]

        public string Name { get; set; }

        public ProductImage ProductImage { get; set; }

        public int ProductImageId { get; set; }

        [Required]

        public string Description { get; set; }

        [ForeignKey(nameof(SubCategory))]
        public int SubCategoryId { get; set; }

        public SubCategory SubCategory { get; set; }
    }
}
