using System;
using System.Collections.Generic;
using System.Text;

namespace PiotrPlayground.DatabasePlayground.Model
{
    public class Supervisor
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid DepartmentId { get; set; }
    }
}
