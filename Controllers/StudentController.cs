using StudentDataBaseManagement001.Data;
using StudentDataBaseManagement001.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace StudentDataBaseManagement001.Controllers
{
    public class StudentController : Controller

    {
        readonly private ApplicationDbContext db = new ApplicationDbContext();

        // 1️⃣ INDEX - List all students
        // GET: Student
        public ActionResult Index()
        {
            var students = db.Students.ToList();
            return View(students);
        }

        // 2️⃣ UPSERT (GET) - Add or Edit
        public ActionResult Upsert(int? id)
        {
            if (id == null)
            {
                // Insert
                return View(new Student());
            }

            Student student = db.Students.Find(id);

            if (student == null)
            {
                return HttpNotFound();
            }

            return View(student);
        }

        // 3️⃣ UPSERT (POST) - Insert or Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Upsert(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }

            if (student.StudentId == 0)
            {
                // INSERT
                db.Students.Add(student);
            }
            else
            {
                // UPDATE
                db.Entry(student).State = EntityState.Modified;
            }

            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // 4️⃣ DETAILS
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Student student = db.Students.Find(id);

            if (student == null)
                return HttpNotFound();

            return View(student);
        }

        // 5️⃣ DELETE (GET)
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Student student = db.Students.Find(id);

            if (student == null)
                return HttpNotFound();

            return View(student);
        }

        // 6️⃣ DELETE (POST)
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        // 7️⃣ Dispose
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
           
        