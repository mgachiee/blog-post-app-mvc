using Microsoft.AspNetCore.Mvc;
using Assessment_8.Models;

namespace Assessment_8.ViewComponents;
public class BlogDetailsViewComponent : ViewComponent
{
  public IViewComponentResult Invoke(PostModel post)
  {
    return View(post);
  }
}