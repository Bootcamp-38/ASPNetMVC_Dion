using ASPNETMVC_Dionisius.Context;
using ASPNETMVC_Dionisius.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ASPNETMVC_Dionisius.Controllers
{
    public class DepartmentsController : Controller
    {
        MyContext myContext = new MyContext();
        // GET: Departments
        public ActionResult Index()
        {
            return View(myContext.Departments.ToList());
        }

        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department department = myContext.Departments.Find(id);
            if(department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }
        
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Department department)
        {
            myContext.Departments.Add(department);
            myContext.SaveChanges();
            return RedirectToAction("index");
        }

        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department department = myContext.Departments.Find(id);
            if(department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }
        [HttpPost] [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Department department)
        {
            Department updateDepartment = myContext.Departments.Where(a => a.Id == id).FirstOrDefault();

            if (updateDepartment != null)
            {
                updateDepartment.Name = department.Name;
                myContext.SaveChanges();
                return RedirectToAction("index");
            }
            else return View();
        }

        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department department = myContext.Departments.Find(id);
            if(department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }
        [HttpPost][ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {

            Department deleteDepartment = myContext.Departments.Where(x => x.Id == id).FirstOrDefault();
            if (deleteDepartment != null)
            {
                myContext.Departments.Remove(deleteDepartment);
                myContext.SaveChanges();
                return RedirectToAction("index");
            }
            else return View();
        }
    }
}