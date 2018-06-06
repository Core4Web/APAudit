using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APAudit.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace APAudit.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new CreateTaskVM
            {
                Districts = new List<SelectListItem>
                {
                    new SelectListItem {Value="71", Text="Тульская область"},
                    new SelectListItem {Value="77", Text="Москва"}
                }
            };
            return View(model);
        }
           

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(CreateTaskVM model)
        {
            if (string.IsNullOrEmpty(model.Operator))
                ModelState.AddModelError(nameof(model.Operator), "Введите наименование оператора связи!");
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
                return View(model);
        }
    }
}