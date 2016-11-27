using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelViewControllerExample.Models;

namespace ModelViewControllerExample.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        [HttpGet]
        public ActionResult Index()
        {
            Models.CalcModel model = new CalcModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(Models.CalcModel model)
        {
            int res = model.num1 + model.num2;
            model.result = res;

            ModelState.Remove("result");
            return View(model);

        }

    }
}