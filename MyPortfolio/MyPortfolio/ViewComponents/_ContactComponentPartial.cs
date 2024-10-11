using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Views.Shared.Components
{
    public class _ContactComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }

    }
}
