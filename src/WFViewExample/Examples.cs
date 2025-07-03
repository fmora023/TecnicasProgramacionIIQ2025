using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFViewExample
{
    public partial class Examples : Form
    {
        public Examples()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var arguments = txtElemetosEjercicio1.Text;
            var result = ClassController.Examples.ElementsSum(arguments);
            this.lbl_ResultEx1.Text = $"El resultado de la suma de los elementos es: {result}";
        }
    }
}
