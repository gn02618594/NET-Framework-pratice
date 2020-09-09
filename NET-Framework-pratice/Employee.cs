using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NET_Framework_pratice
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
    public class EmployeeDao
    {
        public static List<Employee> Employees { get; set; } = new List<Employee>
        {
            new Employee{EmployeeId=1,Name="Anson",Address="台北",PhoneNumber="0911"},
            new Employee{EmployeeId=1,Name="Jason",Address="高雄",PhoneNumber="0922"},
            new Employee{EmployeeId=1,Name="Andy",Address="新竹",PhoneNumber="0910"},      
        };
    }
}