//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mvc1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> codes { get; set; }
        public Nullable<int> Age { get; set; }
        public bool Is_Active { get; set; }
        public Nullable<System.DateTime> EnrollDate { get; set; }
    }
}
