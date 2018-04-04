using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_26_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example of DateTime class.
            //DateTime dateTime = new DateTime(1995, 5, 27, 21, 22, 14);
            DateTime yearOfBirth = new DateTime(1995, 5, 27, 21, 22, 14);
            DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

            TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;

            //Console.WriteLine(dateTime);
            Console.WriteLine(ageAtGraduation);
            Console.ReadLine();
        }
    }
}
