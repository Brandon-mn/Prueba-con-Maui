using Microsoft.Maui.Controls;

namespace Moviles
{
    public partial class CreditoPage : ContentPage
    {
        public CreditoPage()
        {
            InitializeComponent();
            // Cargar los datos dinámicamente al inicio
          
        }

       

        // Si necesitas manejar un botón o acción dentro de esta página
        private void OnVerCreditosButtonClick(object sender, EventArgs e)
        {
            // Aquí puedes realizar cualquier acción adicional
            // Como mostrar más detalles, por ejemplo
            CreditoFrame.IsVisible = true; // Mostrar los detalles del crédito cuando se presione el botón
        }
    }
}
