using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    
    
    public class Car
    {
        public Car()
        {
            
        }

        public Car(string makeInp, string modelInp, int yearInp)
        {
            Make = makeInp;
            Model = modelInp;
            Year = yearInp;
        }
                                   

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
