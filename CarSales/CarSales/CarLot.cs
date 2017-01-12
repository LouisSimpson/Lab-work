using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales
{
    public class CarLot
    {
        private List<Vehicle> vehicleStock;

        private int vehicleCurrentlyDisplayed = 0;

        public CarLot()
        {
            vehicleStock = new List<Vehicle>();
        }

        public int VehicleCurrentlyDisplayed
        {
            get { return vehicleCurrentlyDisplayed; }
        }

        public int NumberOfVehicles
        {
            get { return vehicleStock.Count; }
        }

        public string DescribeCurrentVehicle()
        {
            string description;

            if (vehicleStock.Count > 0)
            {
                description = vehicleStock[vehicleCurrentlyDisplayed].Description();
            }
            else
            {
                description = "No vehicles in stock";
            }
            return description;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicleStock.Add(vehicle);
        }

        public void RemoveVehicleAt(int index)
        {
            if (index < vehicleStock.Count)
            {
                vehicleStock.RemoveAt(index);

                LegaliseVehicleCurrentlyDisplayed();
            }
        }

        private void LegaliseVehicleCurrentlyDisplayed()
        {
            if (vehicleCurrentlyDisplayed > (vehicleStock.Count - 1))
            {
                vehicleCurrentlyDisplayed = vehicleStock.Count - 1;     // not this will be -1 if stock is zero

                if (vehicleCurrentlyDisplayed < 0)
                {
                    vehicleCurrentlyDisplayed = 0;  // make sure its legal or zero....
                }

            }
        }

        public bool IsPreviousVehicle()
        {
            if (vehicleCurrentlyDisplayed > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNextVehicle()
        {
            if (vehicleCurrentlyDisplayed < vehicleStock.Count - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void StepToPreviousVehicle()
        {
            if (IsPreviousVehicle())
            {
                vehicleCurrentlyDisplayed--;
            }
        }

        public void StepToNextVehicle()
        {
            if (IsNextVehicle())
            {
                vehicleCurrentlyDisplayed++;
            }
        }
    }
}

