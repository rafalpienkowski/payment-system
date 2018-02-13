using System;
using PaymentSystem.Core.Persistent;

namespace PaymentSystem.Core.Models
{
    public abstract class AddEmployeeTransaction : ITransaction
    {
        private readonly IPayrollRepository _payrollRepository;

        protected AddEmployeeTransaction(IPayrollRepository payrollRepository)
        {
            _payrollRepository = payrollRepository;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public abstract PaymentClassification GetPaymentClassification();
        public abstract PaymentSchedule GetPaymentSchedule();

        public void Validate()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            var employee = new Employee
            {
                Id = Id,
                Name = Name,
                Address = Adress,
                PaymentClassification = GetPaymentClassification(),
                PaymentSchedule = GetPaymentSchedule()
            };

            _payrollRepository.AddEmployee(employee);
        }
    }

    public class AddHourlyEmployee : AddEmployeeTransaction
    {
        public decimal HourlyRate { get; set; }
        public override PaymentClassification GetPaymentClassification()
        {
            throw new NotImplementedException();
        }

        public override PaymentSchedule GetPaymentSchedule()
        {
            return new WeeklySchedule();
        }

        public AddHourlyEmployee(IPayrollRepository payrollRepository) : base(payrollRepository)
        {
        }
    }

    public class AddSalariedEmployee : AddEmployeeTransaction
    {
        public decimal Salary { get; set; }
        public override PaymentClassification GetPaymentClassification()
        {
            throw new NotImplementedException();
        }

        public override PaymentSchedule GetPaymentSchedule()
        {
            return new MonthlySchedule();
        }

        public AddSalariedEmployee(IPayrollRepository payrollRepository) : base(payrollRepository)
        {
        }
    }

    public class AddComissionedEmpoyee : AddEmployeeTransaction
    {
        public decimal Salary { get; set; }
        public decimal ComissionRate { get; set; }
        public override PaymentClassification GetPaymentClassification()
        {
            throw new NotImplementedException();
        }

        public override PaymentSchedule GetPaymentSchedule()
        {
            return new BiweeklySchedule();
        }

        public AddComissionedEmpoyee(IPayrollRepository payrollRepository) : base(payrollRepository)
        {
        }
    }
}