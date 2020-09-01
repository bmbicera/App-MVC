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
            string json = "[{\"DistinguishedName\":\"CN=Jacob Benner,OU=SlaitUsers,OU=Enterprise,DC=cloud,DC=mcc,DC=loc\",\"Name\":\"Jacob Benner\",\"Enabled\":true,\"SamAccountName\":\"jacob.benner\"},{\"DistinguishedName\":\"CN=A A,OU=A,OU=A,DC=A,DC=A,DC=A\",\"Name\":\"A A\",\"Enabled\":true,\"A\":\"A.A\"}]";

            List<Person> Obj = JsonConvert.DeserializeObject<List<Person>>(json);

            int count = 0;
            foreach (Person element in Obj)
            {
                Console.WriteLine("\nDistinguishedName: " + element.DistinguishedName);
                Console.WriteLine("Name: " + element.Name);
                Console.WriteLine("Enabled: " + element.Enabled);
                Console.WriteLine("SamAccountName: " + element.SamAccountName);
                count++;
            }
            return null;
        }
    }

   


}