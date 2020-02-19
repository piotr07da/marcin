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

        public DatabasePlaygroundRunner()
        {
            _databaseFilePath = "test.db";
            _connectionString = $"URI=file:{_databaseFilePath}";
            _databaseExecutor = new DatabaseExecutor(_connectionString);
            _departmentReader = new DepartmentReader(_databaseExecutor);
            _departmentWriter = new DepartmentWriter(_databaseExecutor);

        }

        public void Run()
        {
            Console.WriteLine("Hello World!");

            var dbInitializer = new DatabaseInitializer();
            dbInitializer.InitializeIfNotExist(_databaseFilePath);

            while (true)
            {
                Console.WriteLine("Select operation");
                Console.WriteLine("| exit | add-node | add-department | add-employee | show-nodes | show-departments | show-employees |");

                var consoleCommand = Console.ReadLine();

                switch (consoleCommand)
                {
                    case "exit":
                        return;

                    case "add-node":
                        break;

                    case "add-department":
                        AddDepartment();
                        break;

                    case "add-employee":
                        break;

                    case "show-nodes":
                        break;

                    case "show-departments":
                        ShowDepartments();
                        break;

                    case "show-employees":
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
    }
}
