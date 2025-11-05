using Assessment_8.Models;
namespace Assessment_8.Services;

public class MockPostService : IPostService
{
  public IEnumerable<PostModel> GetAllPosts()
  {
    return new List<PostModel>
    {
      new PostModel
      {
        Id = 1,
        Title = "The Future of AI in Everyday Life",
        Content = "Artificial Intelligence is no longer just a sci-fi concept—it's reshaping how we live, work, and interact. From smart assistants that manage our schedules to predictive analytics in healthcare, AI's potential is boundless. But with great power comes great responsibility. How do we ensure ethical development and widespread accessibility?",
        Author = "Dr. Elena Vasquez"
      },
      new PostModel
      {
        Id = 2,
        Title = "Sustainable Living: Small Changes, Big Impact",
        Content = "In a world facing climate challenges, individual actions matter. Start with simple habits like reducing plastic use, opting for public transport, and supporting local farmers. This post explores practical tips for eco-friendly living and how communities can amplify these efforts for a greener planet.",
        Author = "Marcus Greene"
      },
      new PostModel
      {
        Id = 3,
        Title = "Exploring Hidden Gems in Southeast Asia",
        Content = "Beyond the tourist hotspots, Southeast Asia offers breathtaking hidden treasures. Discover ancient temples in Cambodia's jungles, pristine beaches in the Philippines' lesser-known islands, and vibrant street food scenes in Vietnam's countryside. These destinations promise authentic experiences and unforgettable memories.",
        Author = "Sophia Tran"
      },
      new PostModel
      {
        Id = 4,
        Title = "The Psychology of Productivity",
        Content = "Why do some people seem to accomplish more in a day than others in a week? Dive into the science of productivity, from understanding your circadian rhythms to leveraging techniques like the Pomodoro method. Learn how mindset, environment, and habits play crucial roles in achieving your goals.",
        Author = "Prof. James Harrington"
      },
      new PostModel
      {
        Id = 5,
        Title = "Crafting the Perfect Home Office",
        Content = "With remote work becoming the norm, your home office setup can make or break your productivity. This guide covers ergonomic furniture choices, lighting solutions, and tech gadgets to create a workspace that inspires creativity and maintains work-life balance.",
        Author = "Lila Chen"
      },
      new PostModel
      {
        Id = 6,
        Title = "The Art of Mindful Cooking",
        Content = "Cooking isn't just about nourishment—it's a meditative practice that connects us to our food and ourselves. Explore techniques for mindful meal preparation, from selecting fresh ingredients to savoring each bite. Discover how this approach can transform your relationship with food and enhance your overall well-being.",
        Author = "Chef Antonio Rossi"
      },
      new PostModel
      {
        Id = 7,
        Title = "Blockchain Beyond Cryptocurrency",
        Content = "While Bitcoin put blockchain on the map, its applications extend far beyond digital currencies. From supply chain transparency to secure voting systems, blockchain technology is revolutionizing industries. This post examines real-world implementations and the challenges of widespread adoption.",
        Author = "Dr. Raj Patel"
      },
      new PostModel
      {
        Id = 8,
        Title = "The Power of Storytelling in Business",
        Content = "In a data-driven world, compelling narratives can be your most powerful tool. Learn how successful brands use storytelling to connect with customers, build loyalty, and drive action. From crafting your company's origin story to personal branding, discover the art of narrative marketing.",
        Author = "Emma Thompson"
      },
      new PostModel
      {
        Id = 9,
        Title = "Urban Gardening for Beginners",
        Content = "City dwellers don't need vast plots to grow their own food. This comprehensive guide covers container gardening, vertical farming techniques, and selecting plants suitable for balconies and windowsills. Turn your urban space into a thriving garden and enjoy the satisfaction of homegrown produce.",
        Author = "Green Thumb Greg"
      },
      new PostModel
      {
        Id = 10,
        Title = "The Evolution of Remote Team Collaboration",
        Content = "As distributed workforces become standard, effective collaboration tools and strategies are essential. Explore the latest platforms, communication best practices, and cultural considerations for building strong remote teams. Learn how to foster connection and productivity across time zones and borders.",
        Author = "Sarah Kim"
      }
    };
  }
}