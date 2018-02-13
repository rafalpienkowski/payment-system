using System.Collections.Generic;
using System.Linq;
using PaymentSystem.Core.Models;

namespace PaymentSystem.Core.Persistent
{
    public interface IPayrollRepository
    {
        Employee GetEmployee(int employeeId);
        void AddEmployee(Employee employee);
    }

    public class InMemoryPayrollRepository : IPayrollRepository
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public Employee GetEmployee(int employeeId)
        {
            return _employees.FirstOrDefault(e => e.Id == employeeId);
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }
    }
}
