using MVC_Project.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class HomeController : Controller
    {
        //Using unity block to inject dependent objects (dependeny injection)
        IEmployee employee;
        public HomeController(IEmployee _employee)
        {
            employee = _employee;
        }
        public ActionResult Index()
        {
            return View();
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
        public string UseUnityToGetEmployeeName()
        {
            return employee.GetEmployeeName();
        }

        //https://localhost:44353/home/GetNameViaWCFService
        public string GetNameViaWCFService()
        {
            string name = "";
            EmployeeServiceReference.EmployeeServiceClient employeeServiceClient = new EmployeeServiceReference.EmployeeServiceClient();
            name= employeeServiceClient.GetName();

            EmployeeServiceReference.Employee1Service_NewClient employeeServiceNewClient = new EmployeeServiceReference.Employee1Service_NewClient();
            name+= employeeServiceNewClient.GetNewName();
            return name;
        }
    }
}