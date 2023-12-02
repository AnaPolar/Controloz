using System;
using System.Windows;
using System.Windows.Controls;

namespace Controloz;

public partial class Catalogs : Page
{
    public Catalogs()
    {
        InitializeComponent();
    }
  

    private void MostrarVentanaButton_Click(object sender, RoutedEventArgs e)
    {
        if (seleccionComboBox.SelectedItem is ComboBoxItem selectedItem)
        {
            // Lógica para mostrar la ventana emergente con los controles específicos según la selección
            string opcion = selectedItem.Content.ToString();

            switch (opcion)
            {
                case "Empresa":
                    MostrarVentanaEmpresa();
                    break;
                case "Sucursal":
                    MostrarVentanaSucursal();
                    break;
                case "Proveedor":
                    MostrarVentanaProveedor();
                    break;
                default:
                    MostrarVentanaEmergente();
                    break;
                // Agrega más casos según sea necesario
            }
        }
    }
    
    private void MostrarVentanaEmergente()
    {
        // Lógica para mostrar la ventana emergente con la cantidad de inputs y selects requeridos
        // Puedes crear una nueva ventana, un UserControl o cualquier otro elemento según tus necesidades
        VentanaEmergente ventana = new VentanaEmergente();
        ventana.ShowDialog();
    }

    private void MostrarVentanaEmpresa()
    {
        VentanaEmpresa ventana = new VentanaEmpresa();
        ventana.ShowDialog();
    }

    private void MostrarVentanaSucursal()
    {
        VentanaSucursal ventana = new VentanaSucursal();
        ventana.ShowDialog();
    }

    private void MostrarVentanaProveedor()
    {
        VentanaProveedor ventana = new VentanaProveedor();
        ventana.ShowDialog();
    }


    // Define una clase para el argumento del evento que contiene la opción seleccionada
    public class ComboBoxItemEventArgs : EventArgs
    {
        public string SelectedItem { get; }

        public ComboBoxItemEventArgs(string selectedItem)
        {
            SelectedItem = selectedItem;
        }
    }



   

}