using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Services.Mapping;
using System.Collections.Generic;

namespace AspNetCoreTemplate.Web.ViewModels.Categories
{
    public class CategoryViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string CategoryImageURL { get; set; }

        public string Name { get; set; }

        public List<SubCategory> SubCategories { get; set; } = new List<SubCategory>();
    }
}
