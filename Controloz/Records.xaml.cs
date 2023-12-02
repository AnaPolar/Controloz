using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Controloz
{
    public partial class Records : Page
    {
        private readonly Frame _mainFrame;

        // Constructor que recibe el Frame
        public Records(Frame mainFrame)
        {
            InitializeComponent();
            _mainFrame = mainFrame;

            // Datos de ejemplo
            List<RegistroModel> registros = new List<RegistroModel>
            {
                new RegistroModel { No = "1", Empresa = "Empresa A", UltimoRegistro = "2023-01-01", NoRegistros = "10" },
                new RegistroModel { No = "2", Empresa = "Empresa B", UltimoRegistro = "2023-01-02", NoRegistros = "15" },
            };

            // Vincula los datos al DataGrid
            myDataGrid.ItemsSource = registros;
        }
        

        private void DataGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Manejar el doble clic en la fila
            if (myDataGrid.SelectedItem != null)
            {
                string empresaSeleccionada = ((RegistroModel)myDataGrid.SelectedItem).Empresa;
                // Navegar a la página EmpresaRegistro y pasar el nombre de la empresa como parámetro
                _mainFrame.Navigate(new EmpresaRegistro(_mainFrame, empresaSeleccionada));
            }
        }


        private void GenerarRegistro_Click(object sender, RoutedEventArgs e)
        {
            // Manejar el clic en el botón 'Generar Registro'
            MessageBox.Show("Botón 'Generar Registro' presionado");
            // Aquí puedes navegar a otra página si es necesario
        }
    }

    public class RegistroModel
    {
        public string No { get; set; }
        public string Empresa { get; set; }
        public string UltimoRegistro { get; set; }
        public string NoRegistros { get; set; }
    }
}