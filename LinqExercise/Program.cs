using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine("This is the sum: ");
            var sum = numbers.Sum();
            Console.WriteLine(sum);

            //TODO: Print the Average of numbers
            Console.WriteLine("This is the avg: ");
            var average = numbers.Average();
            Console.WriteLine(average);

            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("Numbers in ascending order: ");
            var ascending = numbers.OrderBy(x => x);
            foreach (var x in ascending)
            {
                Console.WriteLine(x);
            }

            //TODO: Order numbers in decsending order adn print to the console
            Console.WriteLine("Numbers in descending order: ");
            var descending = numbers.OrderByDescending(x => x);
            foreach (var x in descending)
            {
                Console.WriteLine(x);
            }

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Numbers greater than 6: ");
            var greaterThanSix = numbers.Where(x => x > 6);
            foreach (var x in greaterThanSix)
            {
                Console.WriteLine(x);
            }

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Only 4 numbers: ");
            var fourNums = numbers.OrderBy(x => x).Take(4);
            foreach(var x in fourNums)
            {
                Console.WriteLine(x);
            }

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine("My Age at index 4: ");
            numbers.SetValue(24, 4);
            var descendingWithAge = numbers.OrderByDescending(x => x);
            foreach( var x in descendingWithAge)
            {
                Console.WriteLine(x);
            }

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName.
            Console.WriteLine("Names that only start with C or S: ");
            var onlyCorS = employees.Where(name => name.FirstName.ToLower().StartsWith('c') || name.FirstName.ToLower().StartsWith('s')).OrderBy(x => x.FirstName);
            foreach(var x in onlyCorS)
            {
                Console.WriteLine($"{x.FullName}, age: {x.Age}");

            }

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Names over 26 ordered by age and first name");
            var overTwentySix = employees.Where(employee => employee.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName);
            foreach (var x in overTwentySix)
            {
                Console.WriteLine($"{x.FullName}, age {x.Age}");
            }

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35
            Console.WriteLine("Sum and Avg experience of Senior Employees");
            int sumOfExperience = 0;
            var SeniorEmployeesExperience = employees.Where(employee => employee.YearsOfExperience <= 10 || employee.Age > 35);
            Console.WriteLine($"Total Years of exp: {SeniorEmployeesExperience.Sum(x => x.YearsOfExperience)}");
            Console.WriteLine($"Avg experience: {SeniorEmployeesExperience.Average(x => x.YearsOfExperience)}");

            //TODO: Add an employee to the end of the list without using employees.Add()
            Console.WriteLine("Adding an employee without Add");
            var addingEmployee = employees.Append(new Employee("Nate", "Lunceford", 23, 1));

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
