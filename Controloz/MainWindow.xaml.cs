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

namespace Controloz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void LoginClick(object sender, RoutedEventArgs e)
        {
            // Aquí puedes realizar la lógica de autenticación
            // Si la autenticación es exitosa, abre la segunda ventana

            // Supongamos que la autenticación siempre es exitosa para este ejemplo
            MainMenu principal = new MainMenu();
            principal.Show();

            // Cierra la ventana actual si es necesario
            this.Close();
        }
    }
}