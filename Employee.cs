using System;

namespace EmployeeComparisonApp
{
    // The Employee class represents an employee with basic identifying information
    public class Employee
    {
        // Property to store the employee's unique identifier
        public int Id { get; set; }

        // Property to store the employee's first name
        public string FirstName { get; set; }

        // Property to store the employee's last name
        public string LastName { get; set; }

        // Overloading the == operator to compare two Employee objects
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both objects are null, return true
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If either object is null, return false
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // Compare the Id properties of both objects
            return emp1.Id == emp2.Id;
        }

        // Overloading the != operator (must be overloaded in pairs with ==)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Return the opposite result of the == operator
            return !(emp1 == emp2);
        }

        // Override Equals method to maintain consistency with == operator
        public override bool Equals(object obj)
        {
            // Check if the object is an Employee
            if (obj is Employee employee)
            {
                // Compare Id properties
                return this.Id == employee.Id;
            }

            return false;
        }

        // Override GetHashCode when overriding Equals
        public override int GetHashCode()
        {
            // Use Id to generate hash code
            return Id.GetHashCode();
        }
    }
}
