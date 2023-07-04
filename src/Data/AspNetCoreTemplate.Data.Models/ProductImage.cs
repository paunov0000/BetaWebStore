namespace AspNetCoreTemplate.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class ProductImage
    {
        [Key]
        public int Id { get; set; }

        public byte[] Image { get; set; }
    }
}
