using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KevinLopez
{
    public partial class TercerFormulario : Form
    {
        public TercerFormulario()
        {
            InitializeComponent();
        }

        public void TercerFormulario_Load(object sender, EventArgs e)
        {

        }
          
        private void Multiplo(int num1, int num2)
        {
            listBox1.Items.Add(num1);
            if (num1 < num2)
            {
                Multiplo(num1 + 1, num2);
            }          
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            decimal multiplo = Convert.ToDecimal(MultiploTextBox.Text);


            listBox1.Items.Clear();

            for (int i = 1; i <= 100; i++)
            {
                if (i % multiplo == 0)
                {
                    listBox1.Items.Add(i);
                }
                if (i % 3 == 0)
                {
                    listBox1.Items.Add("Kevin");

                }
                else if (i % 5 == 0)
                {
                    listBox1.Items.Add("Lopez");
                }
                
            }

        }

        
    }
}
