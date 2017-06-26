using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.CRUD.Models;

namespace MVC.CRUD.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Default1/

        public ActionResult Index()
        {
            TestDbEntities obj = new TestDbEntities();
            List<TestUserModel> model = new List<TestUserModel>();
            var data = obj.TblTests.ToList();
            foreach (var item in data)
            {
                model.Add(new TestUserModel() { Address = item.Address, Id = item.ID, Name = item.Name });
            }

            return View(model);
        }

        //
        // GET: /Default1/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Default1/Create

        public ActionResult Create()
        {
            var model = new TestUserModel();
            return View(model);
        }

        //
        // POST: /Default1/Create

        [HttpPost]
        public ActionResult Create(TestUserModel model)
        {
            try
            {
                TestDbEntities obj = new TestDbEntities();
                TblTest tbl = new TblTest();
                tbl.Address = model.Address;
                tbl.Name = model.Name;
                obj.TblTests.AddObject(tbl);
                obj.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Default1/Edit/5

        public ActionResult Edit(int Id)
        {
            TestDbEntities obj = new TestDbEntities();
            var data = obj.TblTests.FirstOrDefault(x => x.ID == Id);
            var model = new TestUserModel() { Id = data.ID, Name = data.Name, Address = data.Address };
            return View(model);
        }

        //
        // POST: /Default1/Edit/5

        [HttpPost]
        public ActionResult Edit(TestUserModel model)
        {
            try
            {
                TestDbEntities obj = new TestDbEntities();
                // TODO: Add update logic here
                TblTest data = obj.TblTests.FirstOrDefault(x => x.ID == model.Id);
                data.Name = model.Name;
                data.Address = model.Address;
                obj.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Default1/Delete/5

        public ActionResult Delete(int Id)
        {
            TestDbEntities obj = new TestDbEntities();
            var data = obj.TblTests.FirstOrDefault(x => x.ID == Id);
            obj.TblTests.DeleteObject(data);
            obj.SaveChanges();
            return RedirectToAction("Index");
        }

        //
        // POST: /Default1/Delete/5


    }
}
