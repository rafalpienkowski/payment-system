 using System;

namespace PaymentSystem.Core.Models
{
    public interface ITransaction
    {
        void Validate();
        void Execute();
    } 

    public abstract class EmployeeBased
    {
        public int EmployeeId { get; set; }
    }

    public class RemoveEmployeeTransaction : ITransaction
    {
        public int EmployeeId { get; set; }
        public void Validate()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }

    public class AddTimeCard : EmployeeBased, ITransaction
    {
        public TimeCard TimeCard { get; set; }
        public void Validate()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }

    public class AddSalesReceipt : EmployeeBased, ITransaction
    {
        public SalesReceipt SalesReceipt { get; set; }
        public void Validate()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }


}
