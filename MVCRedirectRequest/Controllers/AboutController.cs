using Microsoft.AspNetCore.Mvc;

namespace MVCRedirectRequest.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //Use RedirectResult in ASP.NET Core MVC
        //Redirect("/Author/Index");
        //RedirectPermanent("/Author/Index");
        //RedirectPermanentPreserveMethod("/Author/Index");
        //RedirectPreserveMethod("/Author/Index");
        [ActionName("Index1")]
        public RedirectResult Index1()
        {
            return new RedirectResult(url: "/Author/Index", permanent: true,preserveMethod: true);
        }
        [ActionName("Index2")]
        public RedirectResult Index2()
        {
            return new RedirectResult(url: "/Author/Index", permanent: true,preserveMethod: true);
        }
        public RedirectResult Index3()
        {
            return Redirect("https://google.com");
        }
        //Use RedirectToActionResult in ASP.NET Core MVC
        public RedirectToActionResult Index4()
        {
            return RedirectToAction(actionName: "Index", controllerName: "Author");
        }
        public RedirectToActionResult Index5()
        {
            return RedirectToAction(actionName: "Privacy");
        }
        //Use RedirectToRouteResult in ASP.NET Core MVC
        public RedirectToRouteResult Index6()
        {
            var routeValue = new RouteValueDictionary
            (   new { action = "View", controller = "Author" });
            return RedirectToRoute(routeValue);
        }
        //Redirect to razor pages in ASP.NET Core MVC
        public IActionResult RedirectToAuthorPage()
        {
            return RedirectToPage("Author");
        }
    }
}
