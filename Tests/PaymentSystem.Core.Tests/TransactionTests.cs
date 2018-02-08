using System;
using System.Collections.Generic;
using Xunit;

namespace PaymentSystem.Core.Tests
{
    public class TransactionTests
    {
        private readonly List<string> lines = new List<string>();

        public TransactionTests()
        {
            lines.Add("AddEmp 1 \"John Deer\" \"Some Address 123\" H 12.50");
            lines.Add("AddEmp 2 \"Marry Deer\" \"Some Address 123\" S 3550");
            lines.Add("AddEmp 3 \"John Deer\" \"Some Other Address 123\" S 3100 125");
        }

        [Fact]
        public void AddEmployeeTransaction_EmployeeAdded()
        {

        }
    }
}
