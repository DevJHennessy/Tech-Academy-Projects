using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_ASP_043
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        
        //You generally put your constructor underneath your property declaration as so, but
        //you don't have to. This overrides the default constructor for the Car class. You
        //are taking control of the constructor. For example, you can set the values here.
        //These are not very useful examples though, so it is more or less nonsensical data.
        //This puts the Car object into a valid state. This shows the values hardcoded.
        public Car()
        {
            this.Make = "Undefined";
            this.Model = "Undefined";
            this.Year = 1980;
            this.Color = "Undefined";
        }

        //ctor is the code snippet for constructor (ctor tab tab).

        //You can create an overloaded constructor method with input parameters. All you
        //have to do is create another constructor with a different method signature.
        //It's a best practice to add several versions of your constructors because the
        //caller may have different information or different use for the new object and
        //you let them decide what it is they can pass in and what they have available to them.
        public Car(string make, string model, int year, string color)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Color = color;
        }
 

        public string FormatDetailsForDisplay()
        {
            return String.Format("Make: {0} - Model: {1} - Year: {2} - Color: {3}", this.Make, this.Model, this.Year.ToString(), this.Color);
        }


    }
}