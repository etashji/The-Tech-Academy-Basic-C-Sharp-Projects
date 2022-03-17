using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;


namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();
        public decimal GetQuote(Insuree insuree)
        {
            insuree.Quote = 50;
            bool hadBirthdayMonth = false;
            bool hadBirthdayDay = false;
            DateTime insureeDOB = Convert.ToDateTime(insuree.DateOfBirth);
            int insureeAge = 0;
            if (insureeDOB.Month <= DateTime.Now.Month)
            {
                hadBirthdayMonth = true;
            }
            if (insureeDOB.Day <= DateTime.Now.Day)
            {
                hadBirthdayDay = true;
            }
            if (hadBirthdayDay == true && hadBirthdayMonth == true)
            {
                insureeAge = DateTime.Now.Year - insureeDOB.Year;
            }
            else
            {
                insureeAge = DateTime.Now.Year - insureeDOB.Year - 1;
            }
            if (insureeAge <= 18)
            {
                insuree.Quote += 100;
            }
            else if (insureeAge > 19 && insureeAge < 25)
            {
                insuree.Quote += 50;
            }
            else
            {
                insuree.Quote += 25;
            }
            if (insuree.CarYear < 2000)
            {
                insuree.Quote += 25;
            }
            else if (insuree.CarYear > 2015)
            {
                insuree.Quote += 25;
            }
            if (insuree.CarMake == "Porsche")
            {
                insuree.Quote += 25;

                if (insuree.CarModel == "911 Carrera")
                {
                    insuree.Quote += 25;
                }
            }
            insuree.Quote += insuree.SpeedingTickets * 10;
            if (insuree.DUI == true)
            {
                insuree.Quote = decimal.Multiply(insuree.Quote, 1.25m);
            }
            if (insuree.CoverageType == true)
            {
                insuree.Quote = decimal.Multiply(insuree.Quote, 1.5m);
            }
            return (insuree.Quote);
        }
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = (from c in db.Insurees select c).ToList();
                List<InsureeVm> insureeVms = new List<InsureeVm>();
                foreach (var insuree in insurees)
                {
                    var insureeVm = new InsureeVm();
                    insureeVm.Id = insuree.Id;
                    insureeVm.FirstName = insuree.FirstName;
                    insureeVm.LastName = insuree.LastName;
                    insureeVm.EmailAddress = insuree.EmailAddress;
                    insureeVm.Quote = insuree.Quote;
                    insureeVms.Add(insureeVm);
                }
                return View(insureeVms);
            }
            
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);


            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = GetQuote(insuree);
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }


    }
}