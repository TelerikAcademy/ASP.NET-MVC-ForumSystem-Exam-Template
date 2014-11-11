using ForumSystem.Web.InputModels.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForumSystem.Web.Controllers
{
    public class QuestionsController : Controller
    {
        // /questions/26864653/mysql-workbench-crash-on-start-on-windows
        public ActionResult Display(int id, string url, int page = 1)
        {
            return Content(id + " " + url);
        }

        // /questions/tagged/javascript
        public ActionResult GetByTag(string tag)
        {
            return Content(tag);
        }

        [HttpGet]
        public ActionResult Ask()
        {
            var model = new AskInputModel();
            return this.View(model);
        }

        [HttpPost]
        public ActionResult Ask(AskInputModel input)
        {
            return Content("POST");
        }
    }
}