using System;

namespace PiotrPlayground.DatabasePlayground.Model
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid SupervisorId { get; set; }
        public Guid DepartmentId { get; set; }
    }
}
