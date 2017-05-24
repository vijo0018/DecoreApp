﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Decore.ClientApp.AlcoholServiceReference;
using Decore.ClientApp.ViewModels;
using Decore.Models;

namespace Decore.ClientApp.Controllers
{
    public class AlcoholController : Controller
    {
        private readonly AlcoholServiceClient _beverageWcfClient = new AlcoholServiceClient();

        public ActionResult Index()
        {

            if (Session["userId"] == null)
                return RedirectToAction("Index", "Home");




            var measures = new List<Measure>
            {
                new Measure {MeasureId = 1, MeasureType = "Styck"},
                new Measure {MeasureId = 2, MeasureType = "Gram"},
                new Measure {MeasureId = 3, MeasureType = "Centiliter"},
                new Measure {MeasureId = 4, MeasureType = "Liter"}
            };

            var viewModel = new BeverageViewModel
            {
                Beverages = _beverageWcfClient.GetBeverage(),
                Measures = measures
            };

            return View(viewModel);
        }



        [HttpPost]
        public ActionResult PostCountBeverage(List<Object> records)
        {

            

            // Wcf client - post list with rows
            // row 1 - Datum - AlcoId - MeausreTypeId - Amount
            // row 2 - Datum - AlcoId - MeausreTypeId - Amount



            return View("Index");
        }
    }
}