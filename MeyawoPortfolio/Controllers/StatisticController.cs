﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;
namespace MeyawoPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        DbMyPortfolioEntities db = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            // Aggregate --> Sum Count Avg Min Max
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.projectCount=db.TblProject.Count();
            ViewBag.messageCount=db.TblContact.Count();
            ViewBag.futureCount=db.TblFuture.Count();
            ViewBag.testimonialCount=db.TblTestimonial.Count();
            ViewBag.serviceCount=db.TblService.Count();
            ViewBag.socialmediaCount=db.TblSocialMedia.Count();
            ViewBag.flutterProjectCount=db.TblProject.Where(x=>x.ProjectCategory == 1).Count();
            ViewBag.isNotReadMessageCount=db.TblContact.Where(x=>x.İsRead == false).Count();
            ViewBag.lastProjectName = db.LastProjectName().FirstOrDefault();
            return View();
        }
    }
}