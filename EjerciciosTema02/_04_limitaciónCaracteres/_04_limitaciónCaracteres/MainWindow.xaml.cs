using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace _04_limitaciónCaracteres
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

        private void textoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Color colorMedio = (Color)ColorConverter.ConvertFromString("#FF992DC1");
            Color colorFinal = (Color)ColorConverter.ConvertFromString("#FFFF0068");
            if (textoTextBox.Text.Length == textoTextBox.MaxLength)
            {
                contadorTextBlock.Foreground = new System.Windows.Media.SolidColorBrush(colorFinal);
                textoTextBox.IsReadOnly = true;
            }
                
            contadorTextBlock.Text = textoTextBox.Text.Length.ToString() + " / 140";
            if (textoTextBox.Text.Length == textoTextBox.MaxLength / 2)
                contadorTextBlock.Foreground = new System.Windows.Media.SolidColorBrush(colorMedio);
        }
    }
}
