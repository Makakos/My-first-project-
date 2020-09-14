using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp.net.Domain;
using asp.net.Domain.Entitys;
using Microsoft.AspNetCore.Mvc;

namespace asp.net.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TextFieldsController : Controller
    {
        private readonly DataManager dataManager;

        public TextFieldsController(DataManager manager)
        {
            dataManager = manager;
        }

        public IActionResult Edit(string CodeWord)
        {
            var entity = dataManager.TextFields.GetTextFieldByCodeWord(CodeWord);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(TextField textField)
        {
            if(ModelState.IsValid)
            {
                dataManager.TextFields.SaveTextField(textField);
                return RedirectToAction("Index","Home");
            }
            return View(textField);
        }
    }
}
