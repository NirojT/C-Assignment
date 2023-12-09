using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssignment
{
    public class Circle : Shape 
    {
        int radius;
       
        public Circle(int radius) {
        this.radius = radius;
        }
        
        
        public override float CalculateArea()
        {
            return (float)(Math.PI * Math.Pow(this.radius, 2));

        }
    }
}
