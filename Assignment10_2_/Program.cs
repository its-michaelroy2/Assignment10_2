namespace Assignment10_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10.2.1 Find positive numbers using LINQ
            Console.WriteLine("Assignment 10.2.1");
            Console.WriteLine("=================\n");

            //Find pos numbers using LINQ
            int[] numbers = { 2, -1, 3, -3, 10, -200 };

            var positiveNumbers = from number in numbers
                                 where number > 0
                                 select number;

            Console.WriteLine("Positive numbers:");
            Console.Write("{ ");
            Console.Write(string.Join(", ", positiveNumbers));
            Console.WriteLine(" }");

            // 10.2.2. Employee list and filtering
            Console.WriteLine("\n\nAssignment 10.2.2");
            Console.WriteLine("=================\n");

            var employees = new List<Employee>
            {
                new Employee { Name = "John Doe", Age = 26, Salary = 9000 },
                new Employee { Name = "Joe Smith", Age = 33, Salary = 5500 },
                new Employee { Name = "Mike Jo Bob", Age = 25, Salary = 4900 },
                new Employee { Name = "Emily Dickinson", Age = 24, Salary = 5500 },
                new Employee { Name = "David Wile", Age = 35, Salary = 9000 }
            };

            var filteredEmployees = from emp in employees
                                    where emp.Salary > 5000 && emp.Age < 30
                                    select emp;

            foreach (var emp in filteredEmployees)
            {
                Console.WriteLine($"Name: {emp.Name}, Age: {emp.Age}, Salary: ${emp.Salary}");
            }
        }
    }
}
