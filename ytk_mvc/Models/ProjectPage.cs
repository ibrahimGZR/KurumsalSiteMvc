using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ytk_mvc.Models
{
    public class ProjectPage
    {
        public List<CategoryModel> Category { get; set; }
        public List<ProjectModel> Project { get; set; }
    }
}