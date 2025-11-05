using Microsoft.AspNetCore.Mvc;

namespace Assessment_8.ViewComponents;

public class TeamSectionViewComponent : ViewComponent
{
  public IViewComponentResult Invoke(IEnumerable<(string Name, string Role, string ImageUrl)> teamMembers)
  {
    return View(teamMembers);
  }
}