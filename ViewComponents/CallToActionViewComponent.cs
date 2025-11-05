using Microsoft.AspNetCore.Mvc;

namespace Assessment_8.ViewComponents;

public class CallToActionViewComponent : ViewComponent
{
  public IViewComponentResult Invoke()
  {
    return View();
  }
}