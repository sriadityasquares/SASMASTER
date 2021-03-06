﻿using BusinessLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers
{
    public class ReportController : Controller
    {
        BookingBL booking = new BookingBL();
        CommonBL common = new CommonBL();
        // GET: Report
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DayWiseReport()
        {
            
            return View();
        }

        public ActionResult PeriodWiseBookingReport()
        {
            List<Projects> projectList = booking.BindProjects();
            List<Year> years = common.BindYear();
            List<Month> months = common.BindMonth();
            ViewBag.ProjectList = new SelectList(projectList, "ProjectID", "ProjectName");
            ViewBag.YearList = new SelectList(years, "YearName", "YearName");
            ViewBag.MonthList = new SelectList(months, "ID", "MonthName");
            return View();
        }

        public ActionResult GetPeriodWiseBookingReport(int option,string fromDate,string toDate,string projects,string years,string months) 
        {
            ReportBL rep = new ReportBL();
            List<GetPeriodWiseBookingDetails> list = rep.BindPeriodWiseBookingInfo(option, fromDate, toDate, projects, years, months);
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        public ActionResult BookingInfoReport()
        {
            List<Projects> projectList = booking.BindProjects();
            ViewBag.ProjectList = new SelectList(projectList, "ProjectID", "ProjectName");
            return View();
        }

        public JsonResult GetReportbyDate(string start, string end,string projectID)
        {
            ReportBL rep = new ReportBL();
            List<GetBookingInfoByDate> list = rep.BindBookingInfo(start, end, projectID);
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}