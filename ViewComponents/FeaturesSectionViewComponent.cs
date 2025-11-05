using Microsoft.AspNetCore.Mvc;

namespace Assessment_8.ViewComponents;

public class FeaturesSectionViewComponent : ViewComponent
{
  public IViewComponentResult Invoke()
  {
    return View();
  }
}