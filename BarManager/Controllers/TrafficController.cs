using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarManager.Controllers
{
    public class TrafficController : Controller
    {
        // GET: Traffic
        public ActionResult Index()
        {
            return View();
        }

        // GET: Traffic/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Traffic/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Traffic/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Traffic/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Traffic/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Traffic/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Traffic/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
