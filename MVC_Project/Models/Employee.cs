using MVC_Project.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Project.Models
{
    public class Employee : IEmployee
    {
        private string name = "Sadan";
        public string GetEmployeeName()
        {
            return this.name;
        }
    }
}