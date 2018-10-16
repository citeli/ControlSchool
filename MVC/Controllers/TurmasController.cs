using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Dados.Context;
using Dominio.Entidades;

namespace MVC.Controllers
{
    [Authorize(Roles = "Administradores")]
    public class TurmasController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Turmas
        public ActionResult Index()
        {
            return View(db.Turmas.Include(t => t.Curso).ToList());
        }

        // GET: Turmas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Turma turma = db.Turmas
                .Include(t => t.Curso)
                .FirstOrDefault(t => t.Id == id);
            if (turma == null)
            {
                return HttpNotFound();
            }
            return View(turma);
        }

        // GET: Turmas/Create
        public ActionResult Create()
        {
            ViewData["CursoId"] = new SelectList(db.Cursos.ToList(), "Id", "NomeCurso");
            return View();
        }

        // POST: Turmas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Turma turma)
        {

            if (ModelState.IsValid)
            {
                db.Turmas.Add(turma);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["CursoId"] = new SelectList(db.Cursos.ToList(), "Id", "NomeCurso", turma.CursoId);
            return View(turma);
        }

        // GET: Turmas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Turma turma = db.Turmas.Include(t => t.Curso).FirstOrDefault(t => t.Id == id);
            if (turma == null)
            {
                return HttpNotFound();
            }
            ViewData["CursoId"] = new SelectList(db.Cursos.ToList(), "Id", "NomeCurso", turma.CursoId);
            return View(turma);
        }

        // POST: Turmas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Turma turma)
        {
            if (ModelState.IsValid)
            {
                db.Entry(turma).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["CursoId"] = new SelectList(db.Cursos.ToList(), "Id", "NomeCurso", turma.CursoId);
            return View(turma);
        }

        // GET: Turmas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Turma turma = db.Turmas.Find(id);
            if (turma == null)
            {
                return HttpNotFound();
            }
            ViewData["CursoId"] = new SelectList(db.Cursos.ToList(), "Id", "NomeCurso", turma.CursoId);
            return View(turma);
        }

        // POST: Turmas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Turma turma = db.Turmas.Include(t => t.Curso).FirstOrDefault(t => t.Id == id);
            db.Turmas.Remove(turma);
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
