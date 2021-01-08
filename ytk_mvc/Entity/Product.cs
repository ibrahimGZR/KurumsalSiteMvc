using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ytk_mvc.Entity
{
    public class Product
    {
        public int Id { get; set; }

        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Ürün Açıklama")]
        public string Description { get; set; }
        public double Price { get; set; }
        [DefaultValue(0)]
        public double DiscontRate { get; set; }
        public int Stock { get; set; }
        public bool IsVisible { get; set; }
        public int CategoryId { get; set; }
        public int ImageFolderId { get; set; }
        public ImageFolder ImageFolders { get; set; }
        public Category Categories { get; set; }
    }
}