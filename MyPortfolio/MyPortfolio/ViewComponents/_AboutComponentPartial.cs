using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Data.Context;

namespace MyPortfolio.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        MyPortfolioContext portfoliaContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = portfoliaContext.Abouts.Select(x=>x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription = portfoliaContext.Abouts.Select(x=>x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail = portfoliaContext.Abouts.Select(x=>x.Details).FirstOrDefault();

        return View(); 
        }
    }
}
