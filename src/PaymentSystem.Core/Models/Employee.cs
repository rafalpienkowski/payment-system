using System;
using System.Collections.Generic;

namespace PaymentSystem.Core.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public PaymentClassification PaymentClassification { get; set; }
        public PaymentSchedule PaymentSchedule { get; set; }
        public List<Affiliation> Affiliations { get; set; }
    }
    
    public abstract class PaymentClassification
    {
    }
    
    public class CommisionedClassification : PaymentClassification
    {
        public decimal BasePay { get; set; }
        public decimal CommisionRate { get; set; }
        public List<SalesReceipt> SalesReceipts { get; set; }
    }

    public class SalesReceipt
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }

    public class SalariedClassification : PaymentClassification
    {
        public decimal MonthlyPay { get; set; }
       
    }

    public class HourlyClassification : PaymentClassification
    {
        public decimal HourlyRate { get; set; }
        public List<TimeCard> TimeCards { get; set; }
    }

    public class TimeCard
    {
        public DateTime Date { get; set; }
        public int Hours { get; set; }
    }
}
