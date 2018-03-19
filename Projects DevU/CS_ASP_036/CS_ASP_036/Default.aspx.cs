using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_036
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //An instance of a class is known as an object. An object is now a class, and a 
            //class in not an object. Below is an instance of the Car class:
            Car myNewCar = new Car();

            //Setting the properties with values:
            myNewCar.Make = "Oldsmobile";
            myNewCar.Model = "Cutlas Supreme";
            myNewCar.Year = 1986;
            myNewCar.Color = "Silver";

            //You make a new variable to assign the method to and pass in the object
            //You use myNewCar, the object, as the input parameter for the method.
            //This means that you are assigning what "car" is in the determineMarketValue 
            //method to the "myNewCar" object. You could use the name myNewCar in the 
            //determineMarketValue method and get the same results, but then the 
            //names would get confusing.
            //double myMarketValueCar = determineMarketValue(myNewCar);

            //You have to change the way you're calling determineMarketValue when it's
            //moved into the class:
            double myMarketValueCar = myNewCar.DetermineMarketValue();


            //Getting the values of those properties:
            resultLabel.Text = String.Format("{0} - {1} - {2} - {3} - {4:C}", myNewCar.Make, myNewCar.Model, myNewCar.Year.ToString(), myNewCar.Color, myMarketValueCar);

        }

        //A method that will allow you to pass an instance of the car class 
        //and inside the helper method do something like print out to screen.
        //Here, you want to pass in an instance of car. Uppercase Car is the class,
        //Lowercase car is the input parameter.

        /*
        private double determineMarketValue(Car car)
        {
            //double carValue = 100.0;
            ////Someday write code to go online and look up the car's value and
            ////retrieve its value in the carValue variable.
            //return carValue;


            //This code checks a condition to give different prices based on the year 
            //of the car. The "car.Year" will be assigned to "myNewCar.Year" in the object.
            double carValue;

            if (car.Year > 1990)
                carValue = 10000.0;
            else
                carValue = 2000.0;
            return carValue;
        }
        */

    }

    class Car
    {
        //The goal is to make four properties (attributes) of the class car:
        //The make, model, year, and color. Properties define the attributes of a class.
        //Methods typically represent what the class can do, a task it can perform.
        //There are several different ways to create properties.
        //The simplest is auto-implemented properties, as shown below:
        //The property is sort of like a variable, with a data type and a name.
        //You begin with typing in prop and tab tab.

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        //Changes the helper method to be part of the car class, and the private is
        //changed to a public, the lowercase determine become DetermineMarketValue
        //for naming convention, and take out the "car" input parameter.
        public double DetermineMarketValue()
        {
            
            double carValue;

            //car is changed to "this" keyword, which helps you understand that this 
            //property was defined earlier in the class.
            if (this.Year > 1990)
                carValue = 10000.0;
            else
                carValue = 2000.0;
            return carValue;


        }

}