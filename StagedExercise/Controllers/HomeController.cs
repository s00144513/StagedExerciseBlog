using StagedExercise.Models;
using StagedExercise.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StagedExercise.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // typicly retrive data from db and inject into view model
            //today we'll fake the data

            Blog odetocode = new Blog { BlogTitle = "Ode To Code", BlogAuthor = "Scott Allen" };
            Blog hm = new Blog
            {
                BlogTitle = "Hansleman minutes",
                BlogAuthor = "Scott Hanselman",

                BlogPosts = new List<Post> { new Post { PostTitle = "A post", PostContent = "ooowee a new post" },
                new Post { PostTitle = "Post 2", PostContent = "and another" } }
            };

            //mock up model
            List<Blog> blogs = new List<Blog>{ odetocode, hm };
            BlogViewModel bvm = new BlogViewModel { TheBlogs = blogs};            

            return View(bvm);
        }

        public ActionResult Details(string id)
        {
            Blog odetocode = new Blog { BlogTitle = "Ode To Code", BlogAuthor = "Scott Allen" };
            Blog hm = new Blog
            {
                BlogTitle = "Hansleman minutes",
                BlogAuthor = "Scott Hanselman",

                BlogPosts = new List<Post> { new Post { PostTitle = "A post", PostContent = "ooowee a new post" },
                new Post { PostTitle = "Post 2", PostContent = "and another" } }
            };

            List<Blog> blogs = new List<Blog> { odetocode, hm };
            BlogViewModel bvm = new BlogViewModel { TheBlogs = blogs };

            foreach (Blog blg in bvm.TheBlogs)
            {
                if (blg.BlogTitle == id )
                    return View(blg);
            }

            
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