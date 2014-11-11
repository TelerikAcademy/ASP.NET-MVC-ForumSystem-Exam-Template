namespace ForumSystem.Web.Controllers
{
    using System.Web.Mvc;

    using AutoMapper.QueryableExtensions;

    using ForumSystem.Data.Common.Repository;
    using ForumSystem.Data.Models;
    using ForumSystem.Web.ViewModels.Home;

    public class HomeController : Controller
    {
        private readonly IDeletableEntityRepository<Post> posts;

        public HomeController(IDeletableEntityRepository<Post> posts)
        {
            this.posts = posts;
        }

        public ActionResult Index()
        {
            this.posts.ActualDelete(this.posts.GetById(3));
            this.posts.SaveChanges();

            var model = this.posts.All().Project().To<IndexBlogPostViewModel>();

            return this.View(model);
        }
    }
}