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

namespace PruebaColaboracion
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Richard Nombre = new Richard();
            Nombre.Show();
        }  private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Daniel Nombre = new Daniel();
            Nombre.Show();
        }  private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Antonio Nombre = new Antonio();
            Nombre.Show();
        }
    }

}
