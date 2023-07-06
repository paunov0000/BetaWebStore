using AspNetCoreTemplate.Data.Common.Repositories;
using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Services.Mapping;
using AspNetCoreTemplate.Web.ViewModels.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

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

        [HttpGet]
        public IActionResult Add()
        {
            var category = new CategoryViewModel();

            return this.View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var category = new Category()
            {
                Name = model.Name,
                CategoryImageURL = model.CategoryImageURL,
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
            };

            await this._categoriesRepository.AddAsync(category);
            await this._categoriesRepository.SaveChangesAsync();
            return this.RedirectToAction(nameof(this.Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var category = await this._categoriesRepository
                .All()
                .Where(x => x.Id == id)
                .Select(x => new CategoryViewModel()
                {
                    CategoryImageURL = x.CategoryImageURL,
                    Name = x.Name,
                    Id = x.Id,
                })
                .FirstOrDefaultAsync();

            return this.View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CategoryViewModel model, int id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var category = await this._categoriesRepository.FindById(id);

            if (category != null)
            {
                category.Name = model.Name;
                category.CategoryImageURL = model.CategoryImageURL;
            }

            await this._categoriesRepository.SaveChangesAsync();
            return this.RedirectToAction(nameof(this.Index));
        }
    }
}
