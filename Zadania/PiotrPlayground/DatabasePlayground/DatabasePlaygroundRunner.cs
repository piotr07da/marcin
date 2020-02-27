using PiotrPlayground.DatabasePlayground.DataAccessLayer;
using PiotrPlayground.DatabasePlayground.Model;
using System;

namespace PiotrPlayground.DatabasePlayground
{
    public class DatabasePlaygroundRunner
    {
        private readonly string _databaseFilePath;
        private readonly string _connectionString;
        private readonly DatabaseExecutor _databaseExecutor;
        private readonly DepartmentReader _departmentReader;
        private readonly DepartmentWriter _departmentWriter;
        //private readonly NodeReader _nodeReader;
        private readonly EmployeeWriter _employeeWriter;


        public DatabasePlaygroundRunner()
        {
            _databaseFilePath = "test.db";
            _connectionString = $"URI=file:{_databaseFilePath}";
            _databaseExecutor = new DatabaseExecutor(_connectionString);
            _departmentReader = new DepartmentReader(_databaseExecutor);
            _departmentWriter = new DepartmentWriter(_databaseExecutor);
            //_nodeReader = new NodeReader(_databaseExecutor);
            _employeeWriter = new EmployeeWriter(_databaseExecutor);

        }

        public void Run()
        {
            var dbInitializer = new DatabaseInitializer();
            dbInitializer.InitializeIfNotExist(_databaseFilePath);

            while (true)
            {
                Console.WriteLine();

                Console.WriteLine("Select operation");
                Console.WriteLine("| exit [e] |");
                Console.WriteLine("| add-node [a-nod] | add-department [a-dep] | add-employee [a-emp] |");
                Console.WriteLine("| show-nodes [sh-nod] | show-departments [sh-dep] | show-employees [sh-emp] |");
                Console.WriteLine("| assign-employee-department [as-emp-dep] | assign-employee-supervisor [as-emp-sup] |");

                Console.WriteLine();

                var consoleCommand = Console.ReadLine();

                Console.WriteLine();

                switch (consoleCommand)
                {
                    case "e":
                    case "exit":
                        return;

                    case "a-nod":
                    case "add-node":
                        //AddNode();
                        break;

                    case "a-dep":
                    case "add-department":
                        AddDepartment();
                        break;

                    case "a-emp":
                    case "add-employee":
                        AddEmployee();
                        break;

                    case "sh-nod":
                    case "show-nodes":
                        //ShowNodes();
                        break;

                    case "sh-dep":
                    case "show-departments":
                        ShowDepartments();
                        break;

                    case "sh-emp":
                    case "show-employees":
                        ShowEmployee();
                        break;

                }

            }
        }

        private void AddDepartment()
        {
            Console.Write("Department name: ");
            var depName = Console.ReadLine();
            var department = new Department();
            department.Id = Guid.NewGuid();
            department.Name = depName;
            _departmentWriter.WriteDepartment(department);
        }

        private void ShowDepartments()
        {
            var deps = _departmentReader.ReadAllDepartments();
            for (var i = 0; i < deps.Length; ++i)
            {
                var dep = deps[i];
                Console.WriteLine($"Department {i + 1}:");
                Console.WriteLine($" - Id: {dep.Id}");
                Console.WriteLine($" - Name: {dep.Name}");
            }
        }
        private void AddEmployee()
        {
            Console.WriteLine("Employee name: ");
            var empName = Console.ReadLine();
            Console.WriteLine("Employe lastname");
            var empLastName = Console.ReadLine();
            var employe = new Employee();
            var department = new Department();
            employe.Id = Guid.NewGuid();
            Console.WriteLine("Department name: ");
            var depRead = Console.ReadLine();

            var deps = _departmentReader.ReadAllDepartments();
            for (var i = 0; i < deps.Length; ++i)
            {
                var dep = deps[i];
                if (dep.Name == depRead) 
                {
                    employe.DepartmentId = dep.Id;
                }
            }
            employe.FirstName = empName;
            employe.LastName = empLastName;

            _employeeWriter.WriteEmployee(employe);
        }
        private void ShowEmployee()
        {

        }
       
      
    }
}
