namespace Tempearature_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtInputTemperature.Text, out double inputTemperature))
            {
                MessageBox.Show("Please enter a valid numeric temparature value.");
                return;
            }

            // We convert based on the unit selected 

            if (rbCelsius.Checked)
            {
                ConvertFromCelsius(inputTemperature);
            }
            else if (rbFahrenheit.Checked)
            {
                ConvertFromFahnreheit(inputTemperature);
            }
            else if (rbKelvin.Checked)
            {
                ConvertFromKelvin(inputTemperature);
            }
            else
            {
                MessageBox.Show("Please select a temperature unit");
            }

        }

        private void ConvertFromCelsius(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            double kelvin = celsius + 273.15;

            txtCelsius.Text = celsius.ToString("F2");
            txtFahrenheit.Text = fahrenheit.ToString("F2");
            txtKelvin.Text = kelvin.ToString("F2");

        }

        private void ConvertFromFahnreheit(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            double kelvin = celsius + 273.15;

            txtCelsius.Text = celsius.ToString("F2");
            txtKelvin.Text = kelvin.ToString("F2");
            txtFahrenheit.Text = fahrenheit.ToString("F2");
        }

        private void ConvertFromKelvin(double kelvin)
        {
            double celsius = kelvin - 273.15;
            double fahrenheit = (celsius * 9 / 5) + 32;

            txtCelsius.Text = celsius.ToString("F2");
            txtFahrenheit.Text = fahrenheit.ToString("F2");
            txtKelvin.Text = kelvin.ToString("F2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInputTemperature.Clear();
            txtCelsius.Clear();
            txtFahrenheit.Clear();
            txtKelvin.Clear();
        }
    }
}
