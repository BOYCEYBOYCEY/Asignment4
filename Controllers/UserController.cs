using Asign4Vishal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asign4Vishal.Controllers
{
    public class UserController : Controller
    {
        MyContext db=new MyContext();
        // GET: User
        public ActionResult Index()
        {
            return RedirectToAction("ShowUser");
        }

        public ActionResult AddUser()
        {
            return View();
        }

        public ActionResult CreateUser()
        {
            return RedirectToAction("AddUser");
        }



        [HttpPost]
        public ActionResult AddUser(User u)
        {
            db.users.Add(u);
            db.SaveChanges();

            return View();
        }

        public ActionResult ShowUser()
        {
            return View(db.users.ToList());
        }

        public ActionResult Delete(int id)
        {
            var item=db.users.Find(id);

            if(item != null)
            {
                db.users.Remove(item);
                db.SaveChanges();
            }

            return RedirectToAction("ShowUser");   
        }

        public ActionResult Edit(int id)
        {
            var item = db.users.Find(id);

            return View(item);
        }

        [HttpPost]
        public ActionResult Edit(User u)
        {
            db.Entry(u).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("ShowUser");


           
        }




    }
}