using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp.net.Domain;
using Microsoft.AspNetCore.Mvc;

namespace asp.net.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager manager;

        public HomeController(DataManager dataManager) => manager = dataManager;

        public IActionResult Index()
        {
            return View(manager.TextFields.GetTextFieldByCodeWord("PageIndex"));
        }

        public IActionResult Contacts()
        {
            return View(manager.TextFields.GetTextFieldByCodeWord("PageContacts"));
        }
    }
}
