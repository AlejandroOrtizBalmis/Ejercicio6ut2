using System.Windows;
using System.Windows.Controls;

namespace Ejercicio6
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


        private void Image_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if ((sender as Image).Opacity == 1) (sender as Image).Opacity = 0.5;
            else (sender as Image).Opacity = 1;

        }
    }
}
