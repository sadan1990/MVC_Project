using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc1.Models
{
    public class UserEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> codes { get; set; }
        public Nullable<int> Age { get; set; }
        public bool Is_Active { get; set; }
    }
}