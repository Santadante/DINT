using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace _06_Opacidad
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

        private void cuatroImage_MouseEnter(object sender, MouseEventArgs e)
        {
            Image i = (Image)sender;
            i.Opacity = 1.0;
        }

        private void cuatroImage_MouseLeave(object sender, MouseEventArgs e)
        {
            Image i = (Image)sender;
            i.Opacity = 0.5;
        }
    }
}
