using System;
using System.Collections.Generic;

namespace PaymentSystem.Core.Models
{
    public class Affiliation
    {
        public List<ServiceCharge> ServiceCharges { get; set; }
    }

    public class ServiceCharge
    {
        public DateTime DateTime { get; set; }
        public decimal Amount { get; set; }
    }
}