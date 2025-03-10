using INF272_Prac2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INF272_Prac2.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PeopleList() 
        {
            List<Person> People = new List<Person>
            {
                new Person()
                {
                    StudentName = "Naledi",
                    StudentNumber = "u24687945",
                    Surname = "Nkwana",
                    Email = "u24687945@gmail.com",
                    MyLink = "~/HTML/Naledi.html"
                },

                new Person()
                {
                    StudentName = "Mihlali",
                    StudentNumber = "u24701654",
                    Surname = "Mbambo",
                    Email = "u24701654@gmail.com",
                    MyLink = "~/HTML/Mihlali.html"
                },

                new Person()
                {
                    StudentName = "Nthabiseng",
                    StudentNumber = "u24631826",
                    Surname = "De Almeida",
                    Email = "u24631826@gmail.com",
                    MyLink = "~/HTML/Nthabiseng.html"


                },

                new Person()
                {
                    StudentName = "Nolizwi",
                    StudentNumber = "u24875602",
                    Surname = "Mlangeni",
                    Email = "u24875602@gmail.com",
                    MyLink = "~/HTML/Noli.html"
                },

                new Person()
                {
                    StudentName = "Nyiko",
                    StudentNumber = "u24722490",
                    Surname = "Mbhalati",
                    Email = "u24722490@gmail.com",
                    MyLink = "~/HTML/Nyiko.html"
                },
            };
            return View(People);
        }
    }
}