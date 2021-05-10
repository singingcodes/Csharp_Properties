using System;
public class Employee
{
   public int Id { get; set; } 
   public string FirstName { get; set; }
   public string LastName { get; set; }
   public int TotalPay { get; set; }

   public void employeDetails()
   {
       Console.WriteLine("Employee details are " + Id + " " + FirstName +" " + LastName + " " + TotalPay); 
   }
}