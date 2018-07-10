using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public class Employee
    {
        public String Name { get; set; }
        public Int32 Id { get; set; }
        public Int32 Age { get; set; }
    }

    public interface ICompany
    {
        IEnumerable<Employee> GetEmployees();
    }

    public class Manager : Employee, ICompany
    {
        public IEnumerable<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee { Name = "Vineet", Id = 1, Age = 40},
                new Employee { Name = "Xyz", Id = 2, Age = 33 },
                new Employee { Name = "Qwerty", Id = 3, Age = 30 }
            };
        }
    }

    public static class Extension
    {
        public static Employee GetEmployeeById(this ICompany list, int id)
        {
            return list.GetEmployees().Where(x => x.Id == id).First();
        }
    }
}
