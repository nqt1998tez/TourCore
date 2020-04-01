using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourCore.Services;

namespace TourCore.Components
{
    public class TourViewComponent : ViewComponent
    {
        private readonly TourService _tourService;
        public TourViewComponent(TourService tourService)
        {
            this._tourService = tourService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_tourService.ShowInTour().ToList());
        }
    }
}
