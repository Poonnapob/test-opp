using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_opp
{
    internal class person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
       

     
        public person(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }


        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
