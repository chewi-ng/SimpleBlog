using SimpleBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult Articles()
        {
            var posts = new Article() {
                Title= "title 1",
                Body= "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor ",
                Description= "Lorem ipsum",
                Author= "First Author",
                //Published= DateTime.Parse("06/25/2020 20:37:02")
            };
            List<Article> list = new List<Article>
            {
                posts
            };
            ViewBag.List = list;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}