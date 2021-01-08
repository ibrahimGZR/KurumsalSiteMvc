using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ytk_mvc.Entity
{
    public class Image
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public string Description { get; set; }
        public int ImageFolderId { get; set; }
        public ImageFolder ImageFolders { get; set; }


    }
}