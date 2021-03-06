﻿using SC82MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SC82MVC.Web.Controllers
{
    public class SampleController : Controller
    {
        public ActionResult SampleMvcInnerSublayout()
        {
            var model = new SampleMvcInnerSublayoutViewModel
            {
                CurrentYear = Sitecore.DateUtil.ToServerTime(DateTime.UtcNow).Year
            };

            return View(model);
        }
    }
}
