﻿using Mvc1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DevDBEntities devDBEntities = new DevDBEntities();
           var employees=  devDBEntities.Employees.ToList();
            var date =(DateTime) employees.FirstOrDefault().EnrollDate;
            var date1= date.ToShortDateString();
            var todayDate = DateTime.Now;
            UserEmployee employee = new UserEmployee();
            employee.Name = "sadankumar";
            employee.codes = new List<string>()
            {
                "sadan","Pragya"
            };
            return View(employee);
        }

        [HttpPost]
        //Post excel data and read data
        public ActionResult SubmitIndex(UserEmployee userEmployee)
        {
            var file= System.Web.HttpContext.Current.Request.Files[0];
            if ((file != null) && (file.ContentLength > 0) && !string.IsNullOrEmpty(file.FileName))   
        {
                string fileName = file.FileName;
                string fileContentType = file.ContentType;
                byte[] fileBytes = new byte[file.ContentLength];
                var data = file.InputStream.Read(fileBytes, 0, Convert.ToInt32(file.ContentLength));
                var usersList = new List<UserEmployee>();
                //using (var package = new ExcelPackage(file.InputStream))
                //{
                //    var currentSheet = package.Workbook.Worksheets;
                //    var workSheet = currentSheet.First();
                //    var noOfCol = workSheet.Dimension.End.Column;
                //    var noOfRow = workSheet.Dimension.End.Row;
                //    for (int rowIterator = 2; rowIterator >= noOfRow; rowIterator++)
                //    {
                //        var user = new UserEmployee();
                //        user.Id = workSheet.Cells[rowIterator, 1].Value.ToString();
                //        user.Name = workSheet.Cells[rowIterator, 2].Value.ToString();
                //        usersList.Add(user);
                //    }
                //}
            }
            return View(userEmployee);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}