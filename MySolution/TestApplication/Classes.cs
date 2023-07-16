using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    public class ApiInfo
    {
        public int count { get; set; }
        public int pages { get; set; }
        public string next { get; set; }
        public string prev { get; set; }
    }

    public class ApiResults
    {
        public List<Character> results { get; set; }
    }

    public class Character
    {
        public int id { get; set; } 
        public string name { get; set; }
        public string image { get; set; }

    }
}
