using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Mentira.Crud.Models;

namespace Mentira.Crud.Controllers
{
    public class TipoClienteController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /TipoCliente/
        public ActionResult Index()
        {
            return View(db.TipoClientes.ToList());
        }

        // GET: /TipoCliente/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoCliente tipocliente = db.TipoClientes.Find(id);
            if (tipocliente == null)
            {
                return HttpNotFound();
            }
            return View(tipocliente);
        }

        // GET: /TipoCliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /TipoCliente/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="TipoClienteId,NombreTipo")] TipoCliente tipocliente)
        {
            if (ModelState.IsValid)
            {
                db.TipoClientes.Add(tipocliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipocliente);
        }

        // GET: /TipoCliente/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoCliente tipocliente = db.TipoClientes.Find(id);
            if (tipocliente == null)
            {
                return HttpNotFound();
            }
            return View(tipocliente);
        }

        // POST: /TipoCliente/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="TipoClienteId,NombreTipo")] TipoCliente tipocliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipocliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipocliente);
        }

        // GET: /TipoCliente/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoCliente tipocliente = db.TipoClientes.Find(id);
            if (tipocliente == null)
            {
                return HttpNotFound();
            }
            return View(tipocliente);
        }

        // POST: /TipoCliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoCliente tipocliente = db.TipoClientes.Find(id);
            db.TipoClientes.Remove(tipocliente);
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
