using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Letter
    {
        //properties
        public string Name { get; set; }
        public string Date { get; set; }
        //constructors
        public Letter(string name, string date)
        {
            Name = name;
            Date = date;
        }
        public override string ToString()
        {
            return (GetType() + "\n the name is " + Name + " and the date is " + Date);
        }

    }
}
