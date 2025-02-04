using System;
using Microsoft.Maui.Controls;
using UX_DesignMaui;

namespace Moviles
{
    public partial class MenuPage : ContentPage
    {
        private bool isMenuVisible = false;
        private bool isSubMenuConsultaVisible = false;
        private bool isSubMenuVencidosVisible = false;
        private bool isSubMenuProximoPago = false;
        private bool isSubMenuFechaCorte = false;
        private bool isSubMenuSolicitarAumento = false;

        public MenuPage()
        {
            InitializeComponent();
        }

        private void ToggleMenuButton_Click(object sender, EventArgs e)
        {
            isMenuVisible = !isMenuVisible;
            MenuOptions.IsVisible = isMenuVisible;
        }

        private void OnConsultaButtonClick(object sender, EventArgs e)
        {
            isSubMenuConsultaVisible = !isSubMenuConsultaVisible;
            SubMenuConsulta.IsVisible = isSubMenuConsultaVisible;
        }

        private void OnVencidosButtonClick(object sender, EventArgs e)
        {
            isSubMenuVencidosVisible = !isSubMenuVencidosVisible;
            SubMenuVencidos.IsVisible = isSubMenuVencidosVisible;
        }
        private void OnProximoPagoButtonClick(object sender, EventArgs e)
        {
            isSubMenuProximoPago = !isSubMenuProximoPago; 
            SubMenuProximoPago.IsVisible = isSubMenuProximoPago;
        }

        private void OnFechaPagoButtonClick(object sender, EventArgs e)
        {
            isSubMenuFechaCorte = !isSubMenuFechaCorte;
            SubMenuFechaCorte.IsVisible = isSubMenuFechaCorte;
        }

        private void OnFechaSubMenuSolicitarAumentoButtonClick(object sender, EventArgs e)
        {
            isSubMenuSolicitarAumento = !isSubMenuSolicitarAumento;
            SubMenuSolicitarAumento.IsVisible = isSubMenuSolicitarAumento;
        }

        private async void OnVerCreditosButtonClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreditoPage());
        }

        private async void OnVerComprasButtonClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Compras());
        }

        private async void OnVerVencidosButtonClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vencidas());
        }
        private async void OnVerProximoPagoButtonClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProximoPago());
        }
        private async void OnVerProximoFechaCorteButtonClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FechaCorte());
        }
        private async void OnVerProximoSolicitarAumentoButtonClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SolicitarAumentoCreditoPage());
        }
        // Otros botones del menú...
        private async void OnOtroBotonClick(object sender, EventArgs e)
        {
            await DisplayAlert("Otro Botón", "Aquí se ejecuta una acción diferente.", "Aceptar");
        }
    }
}
