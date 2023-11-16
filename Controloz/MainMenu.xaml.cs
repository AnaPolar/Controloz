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
        MostrarPagina1();
    }

    private void CatalogosClick(object sender, RoutedEventArgs e)
    {
        MostrarPagina1();
    }

    private void RegistrosClick(object sender, RoutedEventArgs e)
    {
        MostrarPagina2();
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

    private void MostrarPagina1()
    {
        // Muestra la página 1 en el Frame
        mainFrame.Navigate(new Catalogs());
    }

    private void MostrarPagina2()
    {
        // Muestra la página 2 en el Frame
        mainFrame.Navigate(new Records());
    }
    
    private void mainFrame_Navigating(object sender, NavigatingCancelEventArgs e)
    {
        // Oculta la barra de navegación superior (Back/Forward)
        if (e.NavigationMode == NavigationMode.New)
        {
            ((Frame)sender).NavigationUIVisibility = NavigationUIVisibility.Hidden;
        }
    }
}