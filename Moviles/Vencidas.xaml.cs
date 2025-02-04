using System;

namespace Moviles
{
    public partial class Vencidas : ContentPage
    {
        public Vencidas()
        {
            InitializeComponent();
        }

        private async void OnPayClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Grid parentRow = button?.Parent as Grid;

            if (parentRow != null)
            {
                parentRow.IsVisible = false;

                SuccessMessage.IsVisible = true;

                await Task.Delay(2000);
                SuccessMessage.IsVisible = false;
            }
        }
    }
}
