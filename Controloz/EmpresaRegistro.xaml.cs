using System.Windows;
using System.Windows.Controls;

namespace Controloz
{
    public partial class EmpresaRegistro : Page
    {
        
        private readonly Frame _mainFrame;
        private readonly string _nombreEmpresa;

        public EmpresaRegistro(Frame mainFrame, string nombreEmpresa)
        {
            InitializeComponent();
            _mainFrame = mainFrame;
            _nombreEmpresa = nombreEmpresa;
            
            // Asigna el nombre de la empresa al TextBlock
            nombreEmpresaTextBlock.Text = $"Empresa: {nombreEmpresa}";
        }
        
        private void Regresar_Click(object sender, RoutedEventArgs e)
        {
            // Regresar a la página Records
            _mainFrame.Navigate(new Records(_mainFrame));
        }



    }
}