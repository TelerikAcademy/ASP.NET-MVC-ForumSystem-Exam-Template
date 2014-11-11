using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace ForumSystem.Web.InputModels.Questions
{
    public class AskInputModel
    {
        [Display(Name = "Title")]
        public string Title { get; set; }

        [AllowHtml]
        [Display(Name = "Content")]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        [Display(Name = "Tags")]
        public string Tags { get; set; }
    }
}
