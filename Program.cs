using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
        

            string myName = "Onuoha Prince";
            string sex = "Male";
            int year = 2022;
            float month = 04;
            double day = 18;
             decimal wellaSchoolsession = 6;
             string wellaSchoolstrack = "Backend";
             string wellaAgent =  "Time to make money";
             string wellaTutor = "Emmanuel Codease"; 

             //explicit and implicit examples
             double myAge = 29.3;
             int myAgeint = (int)myAge;

             float x = year;
             long y = year;

            Console.WriteLine ("Hello Wellahealth");
            Console.WriteLine(myName);
            Console.WriteLine(sex);
            Console.WriteLine(year);
            Console.WriteLine(month);
            Console.WriteLine(day);
            Console.WriteLine(wellaSchoolsession);
            Console.WriteLine(wellaSchoolstrack);
            Console.WriteLine(wellaAgent);
            Console.WriteLine(wellaTutor);
            Console.WriteLine(myAgeint);
            Console.WriteLine(x);
            Console.WriteLine(y);

        }
    }
}
