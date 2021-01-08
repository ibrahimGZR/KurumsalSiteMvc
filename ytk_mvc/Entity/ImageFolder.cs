using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ytk_mvc.Entity
{
    public class ImageFolder
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Image> Images { get; set; }

        public List<Product> Products { get; set; }

        public List<Project> Projects { get; set; }
    }
}