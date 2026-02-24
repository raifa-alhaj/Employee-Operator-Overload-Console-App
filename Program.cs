using System;

namespace EmployeeComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object
            Employee employee1 = new Employee();

            // Assign values to employee1 properties
            employee1.Id = 1;
            employee1.FirstName = "John";
            employee1.LastName = "Smith";

            // Create the second Employee object
            Employee employee2 = new Employee();

            // Assign values to employee2 properties
            employee2.Id = 1;  // Same Id as employee1 to test equality
            employee2.FirstName = "Jane";
            employee2.LastName = "Doe";

            // Compare the two employees using the overloaded == operator
            bool areEqual = employee1 == employee2;

            // Display the result of the comparison
            Console.WriteLine("Are employee1 and employee2 equal (==)? " + areEqual);

            // Compare the two employees using the overloaded != operator
            bool areNotEqual = employee1 != employee2;

            // Display the result of the != comparison
            Console.WriteLine("Are employee1 and employee2 not equal (!=)? " + areNotEqual);

            // Pause the console so the user can see the results
            Console.ReadLine();
        }
    }
}
