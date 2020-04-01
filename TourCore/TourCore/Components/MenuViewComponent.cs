using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourCore.Models.Db;
using TourCore.Models.ViewModels;
using TourCore.Services;

namespace TourCore.Components
{
    public class MenuViewComponent: ViewComponent
    {
        private readonly MenuService _menuService;
        public MenuViewComponent(TourContext db,MenuService menuService)
        {
            this._menuService = menuService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_menuService.GetMenu().ToList());
        }

    }
}
