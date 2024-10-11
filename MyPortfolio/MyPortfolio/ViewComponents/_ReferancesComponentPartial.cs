using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Data.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ReferancesComponentPartial:ViewComponent
    {
        MyPortfolioContext MyContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = MyContext.Referances.ToList();

        return View(value); }
    }
}
