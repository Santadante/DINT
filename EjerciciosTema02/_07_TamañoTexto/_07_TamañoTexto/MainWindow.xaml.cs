using System.Windows;
using System.Windows.Controls;


namespace _07_TamañoTexto
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

        private void pequeñoRadioButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            textoTextBlock.FontSize = int.Parse(r.Tag.ToString());
        }
    }
}
