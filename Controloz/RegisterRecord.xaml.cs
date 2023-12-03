using System.Windows;
using System.Windows.Controls;

namespace Controloz;

public partial class RegisterRecord : Page
{
    public RegisterRecord()
    {
        InitializeComponent();
    }
    
    private async void SiguienteButton_Click(object sender, RoutedEventArgs e)
    {
        // Mostrar una ventana emergente de confirmación
        var result = MessageBox.Show("¿Desea continuar?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);

        if (result == MessageBoxResult.Yes)
        {
            // Navegar a la página "NewSale"
            NavigationService.Navigate(new NewSale());
        }
        else
        {
            // No hacer nada si el usuario elige "No"
        }
    }

}