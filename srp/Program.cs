namespace SRP_1
{
    // Clase Employee que maneja los datos del empleado
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100;
        }
    }

    // Clase EmployeeReportPrinter que maneja la impresión de informes
    public class EmployeeReportPrinter
    {
        public void PrintReport(Employee employee)
        {
            Console.WriteLine($"Employee: {employee.Name}, Age: {employee.Age}, Salary: {employee.Salary}");
        }
    }

    class Program
    {
        static void Main()
        {
            Employee emp = new Employee("John", 30, 50000);
            emp.IncreaseSalary(10);

            EmployeeReportPrinter printer = new EmployeeReportPrinter();
            printer.PrintReport(emp);  // Imprime el reporte del empleado
        }
    }

}
