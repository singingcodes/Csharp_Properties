using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // student Sarah = new student();
            // Sarah.Id = -2;
            // Console.WriteLine(Sarah.Id);
            // //Sarah.setId(-2);
            // Sarah.setName(null);
            // Sarah.passMark = 100;
            // Console.WriteLine("student details " + Sarah.getName() );
            Employee one = new Employee();
            one.Id = 1;
            one.FirstName = "John";
            one.LastName = "paul";
            one.TotalPay = 6000;
           one.employeDetails();

        }
    }
}
