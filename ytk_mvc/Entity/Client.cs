using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ytk_mvc.Entity
{
    public class Client
    {
        public int Id { get; set; }
        [DisplayName("Müşteri Adı")]
        public string ClientName { get; set; }
        [DisplayName("Şirket Adı")]
        public string CompanyName { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public List<Project> Projects { get; set; }
    }
}