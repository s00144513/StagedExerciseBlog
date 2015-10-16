using StagedExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StagedExercise.ViewModels
{
    //representation of a particular subset of the db
    public class BlogViewModel
    {        
        public List<Blog> TheBlogs { get; set; }
        public int NumerOfBlogs { get { return TheBlogs.Count; } }
    }
}