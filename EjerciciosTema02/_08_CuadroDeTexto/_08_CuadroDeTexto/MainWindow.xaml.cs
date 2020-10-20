using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;


namespace _08_CuadroDeTexto
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

        private void nombreTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1 && ayudaNombreTextBlock.Text == "")
                ayudaNombreTextBlock.Text = "Nombre del cliente";
            else if(e.Key == Key.F1)
                ayudaNombreTextBlock.Text = "";
        }

        private void ApellidosTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1 && ayudaApellidosTextBlock.Text == "")
                ayudaApellidosTextBlock.Text = "Apellidos del cliente";
            else if(e.Key == Key.F1)
                ayudaApellidosTextBlock.Text = "";
        }

        private void edadTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2 && !Regex.IsMatch(edadTextBox.Text, "^[0-9]+$"))
                comprobarEdadTextBlock.Text = "Edad Incorrecta";
            else if(e.Key == Key.F2)
                comprobarEdadTextBlock.Text = "";
        }
    }
}
