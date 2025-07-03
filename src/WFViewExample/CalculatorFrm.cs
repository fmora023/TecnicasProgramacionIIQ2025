using ClassController;
using ClassController.Interfaces;

namespace WFViewExample
{
    public partial class CalculatorFrm : Form
    {
        private ICalculator Calculator { get; set; }

        public CalculatorFrm(ICalculator calc)
        {
            this.Calculator = calc;
            InitializeComponent();
        }

        private void btn_Sum_Click(object sender, EventArgs e)
        {
            var value1 = ArgumentUtilities.ParseStringToInt(txt_Input1.Text);
            var value2 = ArgumentUtilities.ParseStringToInt(txt_Input2.Text);
            if (value1 == null || value2 == null)
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.");
                return;
            }

            var result = this.Calculator.Sum(value1.Value, value2.Value);
            this.txt_Result.Text = result.ToString();
        }
    }
}
