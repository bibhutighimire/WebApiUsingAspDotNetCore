using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiUsingCore.Models
{
    public class Employees
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Name
        {
            public string first { get; set; }
            public string last { get; set; }
        }

        public class MyArray
        {
            public Name name { get; set; }
            public string jobTitle { get; set; }
            public string photoURL { get; set; }
        }

        public class Root
        {
            public List<MyArray> MyArray { get; set; }
        }

    }
}
