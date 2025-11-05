using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Assessment_8.Models;
using Assessment_8.Services;
using System.Net;

namespace Assessment_8.Controllers;

public class BlogController : Controller
{
  private readonly IPostService _postService;
  private readonly ILogger<BlogController> _logger;

  public BlogController(IPostService postService, ILogger<BlogController> logger)
  {
    _postService = postService;
    _logger = logger;
  }

  public IActionResult Index()
  {
    var posts = _postService.GetAllPosts();
    return View(posts);
  }

  public IActionResult Details(int id)
  {
    var post = _postService.GetAllPosts().FirstOrDefault(p => p.Id == id);
    if (post == null)
    {
      return View("NotFound");
    }
    return View(post);
  }

  public new IActionResult NotFound()
  {
    Response.StatusCode = (int)HttpStatusCode.NotFound;
    return View("NotFound");
  }

  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Error()
  {
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }
}
