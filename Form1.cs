namespace CS311_FinalProject_MCM
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double inputValue;
            if (double.TryParse(txtValue.Text, out inputValue))
            {
                if (rdoMetersToFeet.Checked)
                    txtResult.Text = ConvertMetersToFeet(inputValue).ToString();
                else if (rdoFeetToMeters.Checked)
                    txtResult.Text = ConvertFeetToMeters(inputValue).ToString();
                else if (rdoKiloToMiles.Checked)
                    txtResult.Text = ConvertKiloToMiles(inputValue).ToString();
                else if (rdoMilesToKilo.Checked)
                    txtResult.Text = ConvertMilesToKilo(inputValue).ToString();
                else if (rdoCelToFahren.Checked)
                    txtResult.Text = ConvertCelsiusToFahrenheit(inputValue).ToString();
                else if (rdoFahrenToCel.Checked)
                    txtResult.Text = ConvertFahrenheitToCelsius(inputValue).ToString();
                else if (rdoKiloToPound.Checked)
                    txtResult.Text = ConvertKiloToPounds(inputValue).ToString();
                else if (rdoPoundToKilo.Checked)
                    txtResult.Text = ConvertPoundsToKilo(inputValue).ToString();
                else if (rdoGramToOz.Checked)
                    txtResult.Text = ConvertGramsToOunces(inputValue).ToString();
                else if (rdoOzToGram.Checked)
                    txtResult.Text = ConvertOuncesToGrams(inputValue).ToString();
            }
            else
            {
                MessageBox.Show("Invalid input, enter a value!");
            }
        }

        private double ConvertMetersToFeet(double meters)
        {
            return meters * 3.28084;
        }

        private double ConvertFeetToMeters(double feet)
        {
            return feet / 3.28084;
        }

        private double ConvertKiloToMiles(double kilo)
        {
            return kilo * 0.621371;
        }
        private double ConvertMilesToKilo(double mile)
        {
            return mile / 0.621371;
        }

        private double ConvertCelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        private double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        private double ConvertKiloToPounds(double kilo)
        {
            return kilo * 2.20462;
        }

        private double ConvertPoundsToKilo(double pound)
        {
            return pound / 2.20462;
        }

        private double ConvertGramsToOunces(double grams)
        {
            return grams / 28.35;
        }

        private double ConvertOuncesToGrams(double ounces)
        {
            return ounces * 28.35;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            txtValue.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}