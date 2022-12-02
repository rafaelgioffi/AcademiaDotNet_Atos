using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculadoraSimples : ContentPage
    {
        public CalculadoraSimples()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double val1, val2;

            double.TryParse(txtValorA.Text, out val1);
            double.TryParse(txtValorB.Text, out val2);
            Button bt = (Button)sender;

            if (bt.Text == "+")
            {
                lblCalculo.Text = $"{(val1 + val2)}";
                lblstatus.Text = "";
            }
            if (bt.Text == "-")
            {
                lblCalculo.Text = $"{(val1 - val2)}";
                lblstatus.Text = "";
            }
            if (bt.Text == "x")
            {
                if (val1 <= 0 || val2 <= 0)
                {
                    lblstatus.Text = "Todo número multiplicado por 0, é 0";
                    lblCalculo.Text = "";
                }
                else
                {
                    lblCalculo.Text = $"{(val1 * val2)}";
                    lblstatus.Text = "";
                }
            }
            if (bt.Text == "/")
            {
                if (val1 <= 0 || val2 <= 0)
                {
                    lblCalculo.Text = "";
                    lblstatus.Text = "Não é possível dividir qualquer número por 0";
                }
                else
                {
                    lblCalculo.Text = $"{(val1 / val2):F}";
                    lblstatus.Text = "";
                }
            }
        }

    }
}