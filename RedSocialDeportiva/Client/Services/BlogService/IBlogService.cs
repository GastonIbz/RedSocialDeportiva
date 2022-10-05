using RedSocialDeportiva.Shared;

namespace RedSocialDeportiva.Client.Services.BlogService
{
    public interface IBlogService
    {
        List<BlogPost> GetBlogPosts();
        BlogPost GetBlogPostByUrl(string url);

    }
}
