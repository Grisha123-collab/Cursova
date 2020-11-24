using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursova
{
    public class Test
    {
        public string author { get; set; }
        public string title { get; set; }
        public int rating { get; set; }
        public DateTime StartTest { get; set; }
        public DateTime EndTest { get; set; }
        public Test() { }
        public Test(string Author, string Title, int Rating, DateTime startTest, DateTime endTest) 
        {
            Author = author;
            Title = title;
            StartTest = startTest;
            Rating = rating;
            EndTest = endTest;
        }

    }
}
