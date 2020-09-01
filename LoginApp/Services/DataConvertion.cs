using LoginApp.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginApp.Services
{
    public class DataConvertion
    {

        public string ConvertJsonToClass()
        {
            string json = "{\"DistinguishedName\":\"CN=Jacob Benner,OU=SlaitUsers,OU=Enterprise,DC=cloud,DC=mcc,DC=loc\",\"Name\":\"Jacob Benner\",\"Enabled\":true,\"SamAccountName\":\"jacob.benner\"}," +
                    "{\"DistinguishedName\":\"CN=Jacob Benner,OU=SlaitUsers,OU=Enterprise,DC=cloud,DC=mcc,DC=loc\",\"Name\":\"A a\",\"Enabled\":false,\"SamAccountName\":\"A.a\"}";
            Person data = JsonConvert.DeserializeObject<Person>(json);
            Console.WriteLine("DistinguishedName: " + data.DistinguishedName);
            Console.WriteLine("Name: " + data.Name);
            Console.WriteLine("Enabled: " + data.Enabled);
            Console.WriteLine("SamAccountName: " + data.SamAccountName);
            return data.DistinguishedName;
        }
    }

   


}