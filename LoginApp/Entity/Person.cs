using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginApp.Entity
{
    public class Person
    {
        public string DistinguishedName { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public string SamAccountName { get; set; }
    }
}