using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Data.Context;

namespace MyPortfolio.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
            
            return View(values); }

    }
}
