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
    public partial class SegundoFormulario : Form
    {
        public SegundoFormulario()
        {
            InitializeComponent();
        }

        private void SegundoFormulario_Load(object sender, EventArgs e)
        {

        }

                
        private async void TotalPagarAsyncButton_Click(object sender, EventArgs e)
        {
            decimal precio1 = Convert.ToDecimal(Precio1TextBox.Text);
            decimal precio2 = Convert.ToDecimal(Precio2TextBox.Text);


            decimal total = await TotalPagarAsync(precio1, precio2);
            decimal descuento = await TotalPagarAsync(precio1, precio2) / 15;

            MessageBox.Show($"El total a pagar es: {total}"  +
                $"    El Descuento es de: {descuento}");
        }

        private async Task<decimal> TotalPagarAsync(decimal precio1, decimal precio2)
        {
            decimal descuento = await Task.Run(() =>
            {
                return precio1 + precio2;
            });
            return descuento;
        }
    }
}
