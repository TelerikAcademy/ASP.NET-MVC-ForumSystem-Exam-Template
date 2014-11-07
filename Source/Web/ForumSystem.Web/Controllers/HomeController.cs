using ForumSystem.Data;
using ForumSystem.Data.Common.Repository;
using ForumSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForumSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<Post> posts;

        // Poor man's DI
        public HomeController()
            : this(new GenericRepository<Post>(new ApplicationDbContext()))
        {
        }

        public HomeController(IRepository<Post> posts)
        {
            this.posts = posts;
        }

        public ActionResult Index()
        {
            var posts = this.posts.All();

            return View(posts);
        }
    }
}