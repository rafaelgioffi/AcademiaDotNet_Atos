using System;
using Xamarin.Forms;

namespace CalculadoraApp
{
    public partial class MainPage : ContentPage
    {
        public string operacao;
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnAC_Clicked(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            operacao = "";
        }

        private void btnDEL_Clicked(object sender, EventArgs e)
        {
            int tamanho = lblResultado.Text.Length;
            if (tamanho > 0)
            {
                lblResultado.Text = lblResultado.Text.Remove(tamanho - 1, 1);
                operacao = lblResultado.Text;
            }
        }

        private void AddNumero_Clicked(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            operacao += bt.Text;
            lblResultado.Text = operacao;
        }

        private void Calcula_Clicked(object sender, EventArgs e)
        {
            if (operacao.Length > 0)
            {
                double result=0;
                char[] sinais = { '+', '-', 'x', '/','%' };
                string[] operacao2;
                operacao2 = operacao.Split(sinais);

                if (operacao.Contains("+"))
                {
                    result = double.Parse(operacao2[0]) + double.Parse(operacao2[1]);
                    lblResultado.Text = result.ToString();
                }
                if (operacao.Contains("-"))
                {
                    result = double.Parse(operacao2[0]) - double.Parse(operacao2[1]);
                    lblResultado.Text = result.ToString();
                }
                if (operacao.Contains("x"))
                {
                    result = double.Parse(operacao2[0]) * double.Parse(operacao2[1]);
                    lblResultado.Text = result.ToString();
                }
                if (operacao.Contains("/"))
                {
                    try
                    {
                        result = double.Parse(operacao2[0]) / double.Parse(operacao2[1]);
                        lblResultado.Text = result.ToString();
                    }
                    catch (DivideByZeroException ex)
                    {
                        lblResultado.Text = "Não pode dividir por 0";
                    }
                }
                if (operacao.Contains("%"))
                {
                    result = double.Parse(operacao2[0]) * (double.Parse(operacao2[1]) / 100);
                    lblResultado.Text = result.ToString();
                }
                
                operacao = "";
            }

        }
    }
}
