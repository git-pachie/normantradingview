using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {

            var market = HttpContext.Request.Query["Market"];
            var symbol = HttpContext.Request.Query["Symbol"];

            if(string.IsNullOrEmpty(market))
            {
                market = "NASDAQ";
            }


            if (string.IsNullOrEmpty(symbol))
            {
                symbol = "AAPL";
            }


            var model = new Models.Chart
            {
                Market = market
            ,
                Symbol = symbol
                , MarketSymbol = $"{market}:{symbol}"
            };

            return View(model);
        }
    }
}
