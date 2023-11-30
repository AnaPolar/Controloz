using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Controloz;

public partial class MainMenu : Window
{
    public MainMenu()
    {
        InitializeComponent();
        
        // Suscribe al evento Navigating del Frame
        mainFrame.Navigating += mainFrame_Navigating;
        
        // Inicialmente, muestra una página predeterminada (por ejemplo, Página 1)
        MostrarCatalogos();
    }

    private void CatalogosClick(object sender, RoutedEventArgs e)
    {
        MostrarCatalogos();
    }

    private void RegistrosClick(object sender, RoutedEventArgs e)
    {
        MostrarVisualizarRegistros();
    }
    
    private void NuevoRegistroClick(object sender, RoutedEventArgs e)
    {
        MostrarPaginaRegistro();
    }

    private void ToggleMenu_Click(object sender, RoutedEventArgs e)
    {
        // Cambia el ancho del menú para contraerlo o expandirlo
        if (menuGrid.Width == 200)
        {
            // Contraer el menú
            menuGrid.Width = 40;
        }
        else
        {
            // Expandir el menú
            menuGrid.Width = 200;
        }
    }
    
    private void mainFrame_Navigating(object sender, NavigatingCancelEventArgs e)
    {
        // Oculta la barra de navegación superior (Back/Forward)
        if (e.NavigationMode == NavigationMode.New)
        {
            ((Frame)sender).NavigationUIVisibility = NavigationUIVisibility.Hidden;
        }
    }


    private void MostrarCatalogos()
    {
        // Muestra la página 1 en el Frame
        mainFrame.Navigate(new Catalogs());
    }

    private void MostrarVisualizarRegistros()
    {
        // Muestra la página 2 en el Frame
        mainFrame.Navigate(new Records());
    }
    
    private void MostrarPaginaRegistro()
    {
        // Muestra Register Records en el Frame
        mainFrame.Navigate(new RegisterRecord());
    }
    
    private void MostrarPagi()
    {
        // Muestra Register Records en el Frame
        mainFrame.Navigate(new RegisterRecord());
    }
    
    private void PerfilClick(object sender, RoutedEventArgs e)
    {
        // Muestra Register Records en el Frame
        mainFrame.Navigate(new Profile());
    }
}