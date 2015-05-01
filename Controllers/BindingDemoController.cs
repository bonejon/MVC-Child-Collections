using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChildBinding.Models;

namespace ChildBinding.Controllers
{
    public class BindingDemoController : Controller
    {
        // GET: BindingDemo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateParent()
        {
            ParentModel parentModel = new ParentModel();

            return this.View(parentModel);
        }

        [HttpPost]
        public ActionResult CreateParent(ParentModel parentMode)
        {
            return this.RedirectToAction("Index");
        }
    }
}