using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace _01_AdivinarNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Random r = new Random();
        private int n = r.Next(0, 101);

        public MainWindow()
        {
            InitializeComponent();
        }
        private void comprobarButton_Click(object sender, RoutedEventArgs e)
        {
            int numeroIntroducido = Convert.ToInt32(numeroIntroducidoTextBox.Text);
            if (numeroIntroducido == n)
                MensajeTextBlock.Text = "¡¡Has acertado!!";
            else if (numeroIntroducido > n)
                MensajeTextBlock.Text = "Te has pasado";
            else
                MensajeTextBlock.Text = "Te has quedado corto";
        }

        private void reiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            n = r.Next(0, 101);
            MensajeTextBlock.Text = "";
            numeroIntroducidoTextBox.Text = "";
        }
    }
}
