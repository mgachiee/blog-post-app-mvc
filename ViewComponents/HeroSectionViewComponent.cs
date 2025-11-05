using Microsoft.AspNetCore.Mvc;

namespace Assessment_8.ViewComponents;

public class HeroSectionViewComponent : ViewComponent
{
  public IViewComponentResult Invoke()
  {
    return View();
  }
}