﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExperienceITAlumni.Models;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace ExperienceITAlumni.Controllers
{
    public class ChatController : Controller
    {
        //private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Chat
        public ActionResult Index()
        {
            //var user = await UserManager.FindByIdAsync(id);
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //Members members = db.Members.Where(x => x.UserId == user.Id).Single();
            //if (members == null)
            //{
            //    return HttpNotFound();
            //}
            return View();
        }

    }
}