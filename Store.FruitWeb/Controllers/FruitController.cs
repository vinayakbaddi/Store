using AutoMapper;
using FruitCommon;
using FruitService;
using FruitService.ServiceContracts;
using Store.FruitWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.FruitWeb.Controllers
{
    public class FruitController : Controller
    {
        private readonly IFruitOrderService fruitOrderService;

        public FruitController(IFruitOrderService fruitOrderService)
        {
            this.fruitOrderService = fruitOrderService;
        }

        [HttpGet]
        public ActionResult OrderList()
        {
            
            var fruitList = fruitOrderService.GetAll().ToList();
            var fruitListModel= Mapper.Map<List<FruitDTO>,List<FruitModel>>(fruitList).ToList();

            return View(fruitListModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var fruits = Enum.GetValues(typeof(EnumFruitNames)).Cast<EnumFruitNames>().Select(x => new SelectListItem() { Text = x.ToString(), Value = x.ToString() }).ToList();
            var fruitModel = new FruitModel() { FruitList = fruits };
            return View(fruitModel);
        }

        [HttpPost]
        public ActionResult Create(FruitModel fruitModel)
        {
            if (ModelState.IsValid)
            {
                var fruitDTO = Mapper.Map<FruitModel, FruitDTO>(fruitModel);

                fruitOrderService.Add(fruitDTO);
            }

            return RedirectToAction("OrderList", "Fruit");
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            return Content("Under Construction");

        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            return Content("Under Construction");

        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return Content("Under Construction");
        }

        /// <summary>
        /// Search
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult OrderList(FruitModel fruitModel)
        {

            var fruitList = fruitOrderService.GetAll().ToList();
            var fruitListModel = Mapper.Map<List<FruitDTO>, List<FruitModel>>(fruitList).ToList();

            return View(fruitListModel);
        }
    }
}