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

namespace _03_ImagenOpacidadAjuste
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

        private void altaRadioButton_Click(object sender, RoutedEventArgs e)
        {
            imgImage.Opacity = 1;
        }

        private void mediaRadioButton_Click(object sender, RoutedEventArgs e)
        {
            imgImage.Opacity = 0.6;
        }

        private void bajaRadioButton_Click(object sender, RoutedEventArgs e)
        {
            imgImage.Opacity = 0.3;
        }

        private void rellenoRadioButton_Click(object sender, RoutedEventArgs e)
        {
            imgImage.Stretch = Stretch.Fill;
        }

        private void uniformeRadioButton_Click(object sender, RoutedEventArgs e)
        {
            imgImage.Stretch = Stretch.Uniform;
        }

        private void rellenoUniformeRadioButton_Click(object sender, RoutedEventArgs e)
        {
            imgImage.Stretch = Stretch.UniformToFill;
        }

        private void sinAjusteRadioButton_Click(object sender, RoutedEventArgs e)
        {
            imgImage.Stretch = Stretch.None;
        }

        private void rellenoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            imgImage.Stretch = Stretch.Fill;
        }
    }
}
