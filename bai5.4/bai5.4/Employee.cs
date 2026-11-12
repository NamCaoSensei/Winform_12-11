using System;

namespace bai5._4
{
    public class Employee
    {
        public string EmployeeId { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public DateTime StartDate { get; set; } = DateTime.Today;
        public string DepartmentPath { get; set; } = string.Empty;
        public string Gender { get; set; } = "Nam";

        public Employee() { }

        public Employee(string id, string name, string pos, DateTime startDate, string deptPath, string gender = "Nam")
        {
            EmployeeId = id;
            FullName = name;
            Position = pos;
            StartDate = startDate;
            DepartmentPath = deptPath;
            Gender = gender;
        }
    }
}
