using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSales
{
    public partial class Form1 : Form
    {
        CarLot carLot;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carLot = new CarLot();

            Car car = new Car("Ford", "Focus", "FD62 GHY", new DateTime(2014, 4, 15), 17500, Vehicle.Condition.excellent);

            Car car1 = new Car("Ford", "Fiesta", "RL58 HUZ", new DateTime(2013, 2, 17), 12500, Vehicle.Condition.good);

            Car car2 = new Car("vauxhall", "Corsa", "BP09 YLF", new DateTime(2009, 3, 15), 10000, Vehicle.Condition.excellent);
            Car car3 = new Car("Volkswagen", "Golf", "BL07 YZG", new DateTime(2010, 6, 14), 11000, Vehicle.Condition.excellent);
            Car car4 = new Car("Renealt", "Clio", "BP11 MXS", new DateTime(2008, 3, 10), 9000, Vehicle.Condition.poor);
            Van van1 = new Van("Volkswagen", "Transporter", "KL61 ABR", new DateTime(2011, 9, 13), 14500, Vehicle.Condition.good, 745);
            Van van2 = new Van("Volkswagen", "T4", "EK06 ZWS", new DateTime(2016, 6, 06), 50000, Vehicle.Condition.good, 500);
            carLot.AddVehicle(car);
            carLot.AddVehicle(car1);
            carLot.AddVehicle(car2);
            carLot.AddVehicle(car3);
            carLot.AddVehicle(car4);
            carLot.AddVehicle(van1);
            carLot.AddVehicle(van2);

            DisplayVehicle();

        }

        private void DisplayVehicle()
        {
            labelCurrentVehicle.Text = string.Format("Viewing {0} of {1}", carLot.VehicleCurrentlyDisplayed + 1, carLot.NumberOfVehicles);

            textBoxVehicle.Text = carLot.DescribeCurrentVehicle();

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            carLot.StepToNextVehicle();
            DisplayVehicle();

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            carLot.StepToPreviousVehicle();
            DisplayVehicle();

        }

        private void textBoxVehicle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
