using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConverter
{
    public partial class Form1 : Form
    {
        Converter converter = new Converter();

        public Form1()
        {
            InitializeComponent();
        }

        private void fahrButton_Click(object sender, EventArgs e)
        {
           Double temp = Convert.ToDouble(fahrText.Text);
           Double cels = converter.FahrenheitToCelsius(temp);
           Double kelv = converter.FahrenheitToKelvin(temp);
            celsText.Text = cels.ToString();
            kelvText.Text = kelv.ToString();
        }

        private void celsButton_Click(object sender, EventArgs e)
        {
            Double temp = Convert.ToDouble(celsText.Text);
            Double fahr = converter.CelsiusToFahrenheit(temp);
            Double kelv = converter.CelsiusToKelvin(temp);
            fahrText.Text = fahr.ToString();
            kelvText.Text = kelv.ToString();
        }

        private void kelvButton_Click(object sender, EventArgs e)
        {
            Double temp = Convert.ToDouble(kelvText.Text);
            Double fahr = converter.KelvinToFahrenheit(temp);
            Double cels = converter.KelvinToCelsius(temp);
            fahrText.Text = fahr.ToString();
            celsText.Text = cels.ToString();
        }
    }
}
