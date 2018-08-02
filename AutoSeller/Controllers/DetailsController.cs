using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoSeller.Models;

namespace AutoSeller.Controllers
{
    public class DetailsController : Controller
    {
        // GET: Details
        public ActionResult Detail()
        {
            var detail = new Detail() { Name = "New Detail" };
            return View(detail);
        }
    }
}