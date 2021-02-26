using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ytk_mvc.Entity
{
    public class Partner
    {
        public int Id { get; set; }

        [DisplayName("Partner Adı")]
        public string Name { get; set; }
        [DisplayName("Partner Açıklama")]
        public string Description { get; set; }
        public string WebSite { get; set; }
        [DefaultValue(true)]
        public bool IsVisible { get; set; }
        public int ImageFolderId { get; set; }
        public ImageFolder ImageFolders { get; set; }
    }
}