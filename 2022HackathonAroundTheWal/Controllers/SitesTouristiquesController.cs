using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2022HackathonAroundTheWal.Controllers
{
    public class SitesTouristiquesController : Controller
    {
        // GET: SitesTouristiquesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SitesTouristiquesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //GET: SitesTouristiquesController/Details/Balade
        public ActionResult Search(string critere)
        {
            return View();
        }
    }
}
