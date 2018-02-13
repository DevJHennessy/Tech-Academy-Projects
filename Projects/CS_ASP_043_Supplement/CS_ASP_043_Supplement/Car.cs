using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_ASP_043_Suppliment
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double RetailPrice { get; set; }
        public string OptionsPackage { get; set; }

        public Car()
        {
            Make = "Tabor Robomotives";
            Model = "3002";
            Year = 2024;
            Color = "Black";
            RetailPrice = 70000.0;
            OptionsPackage = "";
        }

        //You use the "this" keyword to borrow code from first constructor.
        //You don't want to be rewriting code in overload methods/constructors because it
        //will make your code more confusing and make so you have to remember more about
        //your code and make changes much harder to do.
        public Car(string optionsPackage) : this()
        {
            /*
            Make = "Tabor Robomotives";
            Model = "3001";
            Year = 2023;
            Color = "Black";
            OptionsPackage = optionsPackage;
            */

            if (optionsPackage == "Offroad Package") 
                RetailPrice = 75000.0;
            else if (optionsPackage == "Sports Package")
                RetailPrice = 82000.0;
            else if (optionsPackage == "Touring Package")
                RetailPrice = 85000.0;
        }

        //You can add this and pass in the second constructor so that you don't have
        //to rewrite that code either, so all you have to do it update the one section.
        //When chaining constructors you want the first one to have the most information
        //and each constructor after that to progressively contain less info.
        public Car(string optionsPackage, string color) : this(optionsPackage)
        {
            /*
            Make = "Tabor Robomotives";
            Model = "3001";
            Year = 2023;
            Color = "Black";
            OptionsPackage = optionsPackage;
            */
            /*
            if (optionsPackage == "Offroad Package")
                RetailPrice = 75000.0;
            else if (optionsPackage == "Sports Package")
                RetailPrice = 82000.0;
            else if (optionsPackage == "Touring Package")
                RetailPrice = 85000.0;
            */

            if (color != "Black" && color != "White")
            {
                Color = "Custom";
                RetailPrice += 20000.0;
            }

        }
    }
}