using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ytk_mvc.Entity
{
    public class ParticalPage
    {
        public int Id { get; set; }

        [DisplayName("Sayfa Adı")]
        public string Name { get; set; }
        [DisplayName("Sayfa Başlığı")]
        public string Title { get; set; }
        [DisplayName("Sayfa Açıklama")]
        public string Description { get; set; }
        public string HtmlText { get; set; }
        [DefaultValue(true)]
        public bool IsVisible { get; set; }
    }
}