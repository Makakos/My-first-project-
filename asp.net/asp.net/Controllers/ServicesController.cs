using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp.net.Domain;
using Microsoft.AspNetCore.Mvc;

namespace asp.net.Controllers
{
    public class ServicesController : Controller
    {
        private readonly DataManager manager;

        public ServicesController(DataManager dataManager) => manager = dataManager;

        public IActionResult Index(Guid id)
        {
            if(id!=default)
            {
                return View("ShowService",manager.ServiceItems.GetServiceItemById(id));
            }
            ViewBag.TextField = manager.TextFields.GetTextFieldByCodeWord("PageServices");
            return View(manager.ServiceItems.GetServiceItems());
        }
    }
}
