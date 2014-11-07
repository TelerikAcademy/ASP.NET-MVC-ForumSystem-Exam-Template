using ForumSystem.Data.Models;
using ForumSystem.Web.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForumSystem.Web.ViewModels.Home
{
    public class IndexBlogPostViewModel : IMapFrom<Post>
    {
        public string Title { get; set; }
    }
}