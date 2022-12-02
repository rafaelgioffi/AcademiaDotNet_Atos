using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParOuImpar : ContentPage
    {
        public ParOuImpar()
        {
            InitializeComponent();
            btnExecutar.Clicked += BtnExecutar_Clicked;
            btnIMC.Clicked += BtnIMC_Clicked;
        }

        private void BtnIMC_Clicked(object sender, EventArgs e)
        {
            double peso, altura, imc;

            double.TryParse(txtPeso.Text, out peso);
            double.TryParse(txtAltura.Text, out altura);

            if(altura > 0 && peso > 0)
            {
                imc = peso * 2 / altura;
                lblResp.Text = $"Seu I.M.C. é de {imc:F}";
            }
            else
            {
                lblResp.Text = "Informe o peso e altura antes de calcular o I.M.C.";
            }
        }

        private void BtnExecutar_Clicked(object sender, EventArgs e)
        {
            int n;
            int.TryParse(txtNumero.Text, out n);

            if (n > 0)
            {
                if (n % 2 == 0)
                {
                    lblResp.Text = n.ToString() + " é par";
                }
                else
                {
                    lblResp.Text = n.ToString() + " é ímpar";
                }
            }
            else
            {
                lblResp.Text = "Favor informe um valor";
            }
        }

    }
}