using Microsoft.AspNetCore.Mvc;

namespace Assessment_8.ViewComponents;

public class ProjectOverviewViewComponent : ViewComponent
{
  public IViewComponentResult Invoke()
  {
    return View();
  }
}