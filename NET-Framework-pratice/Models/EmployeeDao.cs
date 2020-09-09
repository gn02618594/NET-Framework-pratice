using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NET_Framework_pratice.Models
{
    public class EmployeeDao
    {
        public static List<Employee> Employees { get; set; } = new List<Employee>
        {
            new Employee {EmployeeId=1,Name="Anson",Address="台北",PhoneNumber="0911" },
            new Employee {EmployeeId=2,Name="Jason",Address="高雄",PhoneNumber="0922" },
            new Employee {EmployeeId=3,Name="Andy",Address="新竹",PhoneNumber="0910" },
        };
    }
}