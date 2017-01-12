using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales
{
    public abstract class Vehicle : IComparable
    {
        public enum Condition
        {
            poor,
            fair,
            good,
            excellent
        };

        protected string registration;
        protected string make;
        protected string model;
        protected DateTime dateManufactured;
        protected decimal originalPrice;
        protected Condition condition;

        public Vehicle (string make, string model,
            string registration, DateTime dateManufactured,
            decimal originalPrice, Condition condition)
        {
            this.make = make;
            this.model = model;
            this.registration = registration;
            this.dateManufactured = dateManufactured;
            this.originalPrice = originalPrice;
            this.condition = condition;
        }

        public int CalculateApproximateAgeInYears()
        {
            DateTime now = DateTime.Now;
            TimeSpan ageAsTimeSpan = now.Subtract(dateManufactured);
            int ageInYears = ageAsTimeSpan.Days / 365;

            return ageInYears;
        }

        public abstract decimal CalculateApproximateValue();

        public virtual string Description()
        {
            string conditionName = Enum.GetName(typeof(Condition), condition);

            string description = string.Format("Make: {0}{1}Model:{2}{3}Registration: {4}{5}Condition: {6}{7}Current Value: {8:c}",
                make,
                Environment.NewLine,
                model,
                Environment.NewLine,
                registration,
                Environment.NewLine,
                conditionName,
                Environment.NewLine,
                CalculateApproximateValue());
            return description;
        }

        int IComparable.CompareTo(object obj)
        {
            Vehicle otherVehicle = (Vehicle)obj;
            decimal differenceInPrice = this.CalculateApproximateValue() -
                otherVehicle.CalculateApproximateValue();

            return Math.Sign(differenceInPrice);
        }
    }
}
