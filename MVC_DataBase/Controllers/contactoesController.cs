using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_DataBase.Models;

namespace MVC_DataBase.Controllers
{
    public class contactoesController : Controller
    {
        private agenda db = new agenda();

        // GET: contactoes
        public ActionResult Index()
        {
            return View(db.Contactos.ToList());
        }

        // GET: contactoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            contacto contacto = db.Contactos.Find(id);
            if (contacto == null)
            {
                return HttpNotFound();
            }
            return View(contacto);
        }

        // GET: contactoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: contactoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombres,primerApellido,segundoApellido,numeroTelefono,numeroCelular,email")] contacto contacto)
        {
            if (ModelState.IsValid)
            {
                db.Contactos.Add(contacto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contacto);
        }

        // GET: contactoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            contacto contacto = db.Contactos.Find(id);
            if (contacto == null)
            {
                return HttpNotFound();
            }
            return View(contacto);
        }

        // POST: contactoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombres,primerApellido,segundoApellido,numeroTelefono,numeroCelular,email")] contacto contacto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contacto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contacto);
        }

        // GET: contactoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            contacto contacto = db.Contactos.Find(id);
            if (contacto == null)
            {
                return HttpNotFound();
            }
            return View(contacto);
        }

        // POST: contactoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            contacto contacto = db.Contactos.Find(id);
            db.Contactos.Remove(contacto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
