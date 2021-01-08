using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ytk_mvc.Entity
{
    public class User
    {
       
        public int Id { get; set; }
        [DisplayName("Kullanıcı Adı")]
        public string Name { get; set; }
        [DisplayName("Şifre")]
        public string Password { get; set; }
        public string Role { get; set; }

    }
}