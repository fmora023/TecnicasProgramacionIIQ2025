using ClassController;

namespace WFViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var calcFrm = new CalculatorFrm(new Calculator());
            calcFrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var examplesFrm = new Examples();
            examplesFrm.Show();
        }
    }
}
