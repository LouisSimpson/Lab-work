using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales
{
    public class Car : Vehicle
    {
        public Car(string make, string model, string registration, DateTime
            dateManufactured, decimal originalPrice, Condition condition)
            : base(make, model, registration, dateManufactured, originalPrice, condition)
        {

        }

        public override decimal CalculateApproximateValue()
        {
            decimal value = 0;

            if (condition == Condition.excellent)
            {
                value = originalPrice * 0.6m;
            }
            else if (condition == Condition.good)
            {
                value = originalPrice * 0.5m;
            }
            else if (condition == Condition.fair)
            {
                value = originalPrice * 0.4m;
            }
            else if (condition == Condition.poor)
            {
                value = originalPrice * 0.3m;
            }

            int age = CalculateApproximateAgeInYears();

            for (int i = 0; i < age; i++)
            {
                value = value * 0.9m;
            }

            value = Decimal.Round(value, 0);

            value = value - (value % 100);

            value = value + 99;
            return value;
        }
    }
}
