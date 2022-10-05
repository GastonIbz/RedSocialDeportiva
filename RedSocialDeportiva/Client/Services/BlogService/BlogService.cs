using RedSocialDeportiva.Shared;

namespace RedSocialDeportiva.Client.Services.BlogService
{
    public class BlogService : IBlogService
    {
        public List<RedSocialDeportiva.Shared.BlogPost> Posts { get; set; } = new List<RedSocialDeportiva.Shared.BlogPost>()
        {
            new RedSocialDeportiva.Shared.BlogPost ()
            {Url="new-tutorial", Title="Aca iria el titulo", Description="Aca va la descripcion del post", Content="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
            new RedSocialDeportiva.Shared.BlogPost ()
            {Url="first-post", Title="Aca esta el otro titulo", Description="Descripcion cualquiera", Content="This is my beatiful short blog post. Isn´t it nice? :)"}
        };
        public BlogPost GetBlogPostByUrl(string url)
        {
            return Posts.FirstOrDefault(p => p.Url.ToLower().Equals(url.ToLower()));
        }

        public List<BlogPost> GetBlogPosts()
        {
            return Posts;
        }
    }
}
