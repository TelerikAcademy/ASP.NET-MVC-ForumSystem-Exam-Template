namespace ForumSystem.Web.Infrastructure
{
    public interface ISanitizer
    {
        string Sanitize(string html);
    }
}
