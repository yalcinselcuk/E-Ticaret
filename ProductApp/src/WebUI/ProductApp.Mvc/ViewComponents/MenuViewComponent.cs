﻿using Microsoft.AspNetCore.Mvc;
using ProductApp.Services;

namespace ProductApp.Mvc.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public MenuViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
            var categories = _categoryService.GetCategoryDisplayResponses();
            return View(categories);
        }
    }
}
