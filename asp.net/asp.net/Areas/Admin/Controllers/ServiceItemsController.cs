﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using asp.net.Domain;
using asp.net.Domain.Entitys;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace asp.net.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceItemsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostEnvironment;

        public ServiceItemsController(DataManager manager,IWebHostEnvironment environment)
        {
            dataManager = manager;
            hostEnvironment = environment;
        }

        public IActionResult Edit(Guid id)
        {
            var entity = id==default?new ServiceItem():dataManager.ServiceItems.GetServiceItemById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(ServiceItem item,IFormFile titleimage)
        {
            if(ModelState.IsValid)
            {
                if (titleimage != null)
                {
                    item.TitleImagePath = titleimage.FileName;
                    using (var stream = new FileStream(Path.Combine(hostEnvironment.WebRootPath, "images/", titleimage.FileName), FileMode.Create))
                    {
                        titleimage.CopyTo(stream);
                    }
                }
                dataManager.ServiceItems.SaveServiceItem(item);
                return RedirectToAction("Index","Home");
            }
            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.ServiceItems.DeleteServiceItem(id);
            return RedirectToAction("Index", "Home");
        }
       
    }
}
