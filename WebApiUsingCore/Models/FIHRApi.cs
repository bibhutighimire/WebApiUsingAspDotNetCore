using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiUsingCore.Models
{
    public class FIHRApi
    {
        public class Address
        {
            public List<string> line { get; set; }
            public string city { get; set; }
            public string postalCode { get; set; }
            public string state { get; set; }
        }

        public class Location
        {
            public string name { get; set; }
            public Address address { get; set; }
        }
        public class Example
        {
            public int id { get; set; }
            public string name { get; set; }
            public string resource_url { get; set; }
            public string logo { get; set; }
            public string api_version { get; set; }
            public string status { get; set; }
            public string ehr { get; set; }
           
            public List<Location> locations { get; set; }
        }
        public class Root
        {
           
            public List<Example> example { get; set; }
            

        }

        //public class Address
        //{
        //    public List<string> line { get; set; }
        //    public string city { get; set; }
        //    public string postalCode { get; set; }
        //    public string state { get; set; }
        //}

        //public class Location
        //{
        //    public string name { get; set; }

        //}

        //public class Example
        //{
        //    public int id { get; set; }
        //    public string name { get; set; }
        //    public string resource_url { get; set; }
        //    public string logo { get; set; }
        //    public string api_version { get; set; }
        //    public string status { get; set; }
        //    public string ehr { get; set; }
        //    public List<Location> locations { get; set; }
        //    public Address address { get; set; }

        //}

    }
}
