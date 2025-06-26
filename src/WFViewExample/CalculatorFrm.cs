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
            var value1 = ParseStringToInt(txt_Input1.Text);
            var value2 = ParseStringToInt(txt_Input2.Text);
            if (value1 == null || value2 == null)
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.");
                return;
            }

            var result = this.Calculator.Sum(value1.Value, value2.Value);
            this.txt_Result.Text = result.ToString();
        }

        private int? ParseStringToInt(string input)
        {
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
