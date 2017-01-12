using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace CarSales
{
    public class Van : Vehicle
    {
        protected double payload;

        public Van( string make, string model, string registration, DateTime
            dateManufactured, decimal originalPrice, Condition condition, double payload)
            : base(make, model, registration, dateManufactured, originalPrice,condition)
        {
            this.payload = payload;
        }

        public override decimal CalculateApproximateValue()
        {
            decimal value = 0;

            if (condition == Condition.excellent)
            {
                value = originalPrice * 0.7m;        // 70% of original value
            }
            else if (condition == Condition.good)
            {
                value = originalPrice * 0.6m;        // 60% of original value
            }
            else if (condition == Condition.fair)
            {
                value = originalPrice * 0.5m;        // 50% of original value
            }
            else if (condition == Condition.poor)
            {
                value = originalPrice * 0.4m;        // 40% of original value
            }

            int age = CalculateApproximateAgeInYears();

            for (int i = 0; i < age; i++)
            {
                value = value * 0.95m;
            }

            value = Decimal.Round(value, 0);

            value = value - (value % 100);

            value = value + 99;
            return value;
        }

        public override string Description()
        {
            string description = base.Description() + Environment.NewLine + string.Format("payload: {0}kg", payload);

            return description;
        }
    }
}
