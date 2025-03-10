using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace INF272_Prac2.Models
{
    public class Person
    {
        [DisplayName("STUDENT NAME")]
        public string StudentName { get; set; }
        [DisplayName("STUDENT NUMBER")]
        public string StudentNumber { get; set; }
        [DisplayName("SURNAME")]
        public string Surname { get; set; }
        [DisplayName("EMAIL")]
        public string Email { get; set; }

        [Display(Name = "Link to personal page")]
        public string MyLink { get; set; }
    }
}