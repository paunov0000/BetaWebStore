using AspNetCoreTemplate.Data.Common.Repositories;
using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Services.Mapping;
using AspNetCoreTemplate.Web.ViewModels.Categories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AspNetCoreTemplate.Web.Controllers
{
    public class CategoryController : BaseController
    {
        private readonly IDeletableEntityRepository<Category> _categoriesRepository;

        public CategoryController(IDeletableEntityRepository<Category> categoriesRepository)
        {
            this._categoriesRepository = categoriesRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var categories = this._categoriesRepository.All()
                .Where(x => x.IsDeleted == false)
                .OrderBy(x => x.Name)
                .To<CategoryViewModel>()
                .ToList();


            return this.View(categories);
        }
    }
}
