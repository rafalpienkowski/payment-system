using System;
using System.Collections.Generic;

namespace PaymentSystem.Core.Models
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public IPayClassification PayClassification { get; set; }
    }

    public interface IPayClassification
    {
        void CalculatePay();
    }

    public class CommisionedClassification : IPayClassification
    {
        public decimal BasePay { get; set; }
        public decimal CommisionRate { get; set; }
        public List<SalesReceipt> SalesReceipts { get; set; }

        public void CalculatePay()
        {
            throw new System.NotImplementedException();
        }
    }

    public class SalesReceipt
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }

    public class SalariedClassification : IPayClassification
    {
        public decimal MonthlyPay { get; set; }
        public void CalculatePay()
        {
            throw new NotImplementedException();
        }
    }

    public class HourlyClassification : IPayClassification
    {
        public decimal HourlyRate { get; set; }
        public List<TimeCard> TimeCards { get; set; }
        public void CalculatePay()
        {
            throw new NotImplementedException();
        }
    }

    public class TimeCard
    {
        public DateTime Date { get; set; }
        public int Hours { get; set; }
    }
}
