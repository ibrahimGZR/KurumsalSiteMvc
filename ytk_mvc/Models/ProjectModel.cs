using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ytk_mvc.Models
{
    public class ProjectModel
    {
        public int Id { get; set; }

        [DisplayName("Proje Adı")]
        public string Name { get; set; }
        [DisplayName("Proje Açıklama")]
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        [DefaultValue(true)]
        public bool IsVisible { get; set; }
        public int ClientId { get; set; }
        public int ImageFolderId { get; set; }
        public int CategoryId { get; set; }
    }
}