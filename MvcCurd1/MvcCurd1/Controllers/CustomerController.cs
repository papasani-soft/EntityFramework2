﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCurd1.Models;

namespace MvcCurd1.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer/Index
        public ActionResult Index()
        {
            using (DbModels dbModels = new DbModels())

            { return View(dbModels.Customers.ToList()); }
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels dbModels = new DbModels())
            { return View(dbModels.Customers.Where(x => x.Id == id).FirstOrDefault()); }
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    dbModels.Customers.Add(customer);
                    dbModels.SaveChanges();
                }
                    // TODO: Add insert logic here

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels dbModels = new DbModels())
            { return View(dbModels.Customers.Where(x => x.Id == id).FirstOrDefault()); }
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Customer customer)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    dbModels.Entry(customer).State = System.Data.Entity.EntityState.Modified;
                    dbModels.SaveChanges();
                }
                    // TODO: Add update logic here

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels dbModels = new DbModels())
            { return View(dbModels.Customers.Where(x => x.Id == id).FirstOrDefault()); }
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    Customer customer = dbModels.Customers.Where(x => x.Id == id).FirstOrDefault();
                    dbModels.Customers.Remove(customer);
                    dbModels.SaveChanges();
                }
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
