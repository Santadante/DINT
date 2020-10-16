using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _02_cálculos_matemáticos_básicos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, RoutedEventArgs e)
        {
            if(Regex.IsMatch(primerNumeroTextBox.Text,"^[0-9]?[.]?[0-9]+$") && Regex.IsMatch(segundoNumeroTextBox.Text,"^[0-9]?[.]?[0-9]+$"))
            {
                double n1 = double.Parse(primerNumeroTextBox.Text);
                double n2 = double.Parse(segundoNumeroTextBox.Text);

                switch (operacionTextBox.Text)
                {
                    case "+":
                        calcularButton.IsEnabled = true;
                        resultadoTextBox.Text = (n1 + n2).ToString();
                        break;
                    case "-":
                        calcularButton.IsEnabled = true;
                        resultadoTextBox.Text = (n1 - n2).ToString();
                        break;
                    case "*":
                        calcularButton.IsEnabled = true;
                        resultadoTextBox.Text = (n1 * n2).ToString();
                        break;
                    case "/":
                        calcularButton.IsEnabled = true;
                        resultadoTextBox.Text = (n1 / n2).ToString();
                        break;
                    default:
                        MessageBox.Show("Operación introducida no valida");
                        break;
                }
            }
            else
            {
                MessageBox.Show("solo se admiten números");
            }
            
        }

        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            primerNumeroTextBox.Text = "";
            segundoNumeroTextBox.Text = "";
            operacionTextBox.Text = "";
            resultadoTextBox.Text = "";
        }
    }
}
