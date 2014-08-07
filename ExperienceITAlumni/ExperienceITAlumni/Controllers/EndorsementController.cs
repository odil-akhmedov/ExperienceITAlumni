using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExperienceITAlumni.Models;
using System.IO;

namespace ExperienceITAlumni.Controllers
{
    public class EndorsementController : Controller
    {
        private AlumniDBEntities1 db = new AlumniDBEntities1();

        // GET: Endorsement
        public ActionResult Index()
        {
            return View(db.Endorsements.ToList());
        }

        // GET: Endorsement/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Endorsement endorsement = db.Endorsements.Find(id);
            if (endorsement == null)
            {
                return HttpNotFound();
            }
            return View(endorsement);
        }

        // GET: Endorsement/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Endorsement/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public FileResult Create([Bind(Include = "EndorsementID,Your_Name,Street_Address,City,State,Zip,Email_Address,Today_s_Date,Name_of_Recipient,Title,Company,Recipient_Address,Recipient_City,Recipient_State,Recipient_Zip,Salutation,Paragraph1,Paragraph2,Paragraph3,Paragraph4,Paragraph5,Closing,Titles")] Endorsement endorsement)
        {
            string letterFormat = System.IO.File.ReadAllText(@"C:\Users\Grand\Documents\GitHub\ExperienceITAlumni\ExperienceITAlumni\ExperienceITAlumni\Content\Letter of Endorsement outline.txt");
            string finalLetter = String.Format(
                                                letterFormat,
                                                endorsement.Your_Name,//0
                                                endorsement.Street_Address,
                                                endorsement.City,
                                                endorsement.State,
                                                endorsement.Zip,
                                                endorsement.Email_Address, //5
                                                endorsement.Today_s_Date,
                                                endorsement.Name_of_Recipient,
                                                endorsement.Title,
                                                endorsement.Company,
                                                endorsement.Recipient_Address, //10
                                                endorsement.Recipient_City,
                                                endorsement.Recipient_State,
                                                endorsement.Recipient_Zip,
                                                endorsement.Paragraph1, 
                                                endorsement.Paragraph2, //15
                                                endorsement.Paragraph3,
                                                endorsement.Paragraph4,
                                                endorsement.Paragraph5,
                                                endorsement.Titles //19
                                              );
            MemoryStream m = new MemoryStream();
            StreamWriter t = new StreamWriter(m);
            t.Write(finalLetter);
            t.Flush();
            var f = new FileContentResult(m.ToArray(), "content/text");
            f.FileDownloadName = "Endorsement.txt";
            t.Close();
            t.Dispose();
            return f;
        }

        // GET: Endorsement/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Endorsement endorsement = db.Endorsements.Find(id);
            if (endorsement == null)
            {
                return HttpNotFound();
            }
            return View(endorsement);
        }

        // POST: Endorsement/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EndorsementID,Your_Name,Street_Address,City,State,Zip,Email_Address,Today_s_Date,Name_of_Recipient,Title,Company,Recipient_Address,Recipient_City,Recipient_State,Recipient_Zip,Salutation,Paragraph1,Paragraph2,Paragraph3,Paragraph4,Paragraph5,Closing,Titles")] Endorsement endorsement)
        {
            if (ModelState.IsValid)
            {
                db.Entry(endorsement).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(endorsement);
        }

        // GET: Endorsement/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Endorsement endorsement = db.Endorsements.Find(id);
            if (endorsement == null)
            {
                return HttpNotFound();
            }
            return View(endorsement);
        }

        // POST: Endorsement/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Endorsement endorsement = db.Endorsements.Find(id);
            db.Endorsements.Remove(endorsement);
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
