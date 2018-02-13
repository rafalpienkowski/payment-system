using System;

namespace PaymentSystem.Core.Models
{
    public abstract class PaymentSchedule
    {
        public abstract bool IsPayday(DateTime date);
    }

    public class WeeklySchedule : PaymentSchedule
    {
        public override bool IsPayday(DateTime date)
        {
            throw new NotImplementedException();
        }
    }

    public class MonthlySchedule : PaymentSchedule
    {
        public override bool IsPayday(DateTime date)
        {
            throw new NotImplementedException();
        }
    }

    public class BiweeklySchedule : PaymentSchedule
    {
        public override bool IsPayday(DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}