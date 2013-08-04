using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thunderbird.Business.Implementation;
using Thunderbird.Factory.Entity;

namespace Thunderbird.Web.Controllers
{
    public class SemestreController : Controller
    {
        //
        // GET: /Semestre/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Semestre/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Semestre/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Semestre/Create

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
        
        //
        // GET: /Semestre/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Semestre/Edit/5

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

        //
        // GET: /Semestre/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Semestre/Delete/5

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

        public ActionResult Buscar()
        {
            SemestreRepository _repository = new SemestreRepository();
            IList<Semestre> fromDB = _repository.ObterTodos();

            return PartialView("Table", fromDB.ToList());
        }
    }
}
