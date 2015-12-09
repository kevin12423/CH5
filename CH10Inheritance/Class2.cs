using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class CertifiedLetter : Letter
    {
        //properties
        public int TrackingNumbers
        {
            get;
            set;
        }
        public CertifiedLetter(string name, string date, int trackingNumbers) : base(name, date)
        {
            TrackingNumbers = trackingNumbers;
        }
        public override string ToString()
        {
            return (GetType() + "\n the name is " + Name + " and the date is " + Date + " and the tracking number is " + TrackingNumbers);
        }
    }
}
