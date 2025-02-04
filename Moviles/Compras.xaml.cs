using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviles
{
    public partial class Compras : ContentPage
    {
            public Compras()
            {
                InitializeComponent();

            }
            private async void OnComprarProducto(object sender, EventArgs e)
            {
                var button = sender as Button;
                var producto = button?.CommandParameter as string;

                if (producto != null)
                {
                    await DisplayAlert("Compra Exitosa", $"Gracias por tu compra de {producto}.", "OK");
                }
            }
    }
}
