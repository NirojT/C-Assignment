using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssignment
{
    internal class Car
    {
        private string brand;
        private int year;
        private float price;

        public Car(string brand, int year, float price)
        {
            this.brand = brand;
            this.year = year;
            this.price = price;
        }

        public string getBrand()
        {
            return this.brand;
        }

        public void setBrand(string brand)
        {
            this.brand = brand;
        } 
        public int getYear()
        {
            return this.year;
        }
        public void setYear(int year)
        {
            this.year = year;
        } public float getPrice()
        {
            return this.price;
        }
        public void setPrice(float price)
        {
            this.price = price;
        }
        

       
    }
}
