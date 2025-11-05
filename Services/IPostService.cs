using Assessment_8.Models;
namespace Assessment_8.Services;

public interface IPostService
{
  IEnumerable<PostModel> GetAllPosts();
}