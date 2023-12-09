using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssignment
{
    public class Rectangles
    {
        private float length;

    private float width; 

        public Rectangles(float length, float width)
        {
            this.length = length;
            this.width = width;
        }
        public float getLength() {
        return this.length; 
        } 
        public float getWidth() {
        return this.width; 
        }
        public float CalculateArea()
        {
            float area = this.length * this.width;
           
            return area;    

        }
    
    }
}
