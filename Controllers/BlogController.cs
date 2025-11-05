using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Assessment_8.Models;
using Assessment_8.Services;
using System.Net;

namespace Assessment_8.Controllers;

public class BlogController : Controller
{
  private readonly IPostService _postService;

  public BlogController(IPostService postService)
  {
    _postService = postService;
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
}