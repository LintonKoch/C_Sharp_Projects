using System;
using System.Collections.Generic;
using System.Text;

namespace CarClassLib
{
    public class Car
    {
        //props
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public int Miles { get; set; }

        //Default Constructor
        public Car()
        {
            //this. is optimal
            Make = "noting yet";
            Model = "nothing yet";
            Price = 0.00M;
            Color = "nothing yet";
            Miles = 0;
        }
        //Parameterized Constructor
        public Car(string a,string b, decimal c, string d, int e)
        {
            Make = a;
            Model = b;
            Price = c;
            Color = d;
            Miles = e;
        }

        override public String ToString()
        {
            return  Make + " " + Model + " $" + Price + " " + Color + " "+ Miles; 
        }
    }
}
