using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using System.Text.RegularExpressions;


namespace Moviles
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private async void OnRegisterLabelTapped(object sender, EventArgs e)
        {
            PopupMessage.IsVisible = true;

            await Task.Delay(3000);

            PopupMessage.IsVisible = false;
            await Navigation.PushAsync(new Register());
        }


        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;

            bool isEmailValid = Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            bool isPasswordValid = !string.IsNullOrEmpty(password);  
            if (EmailEntry.Text == "admin@gmail.com" && PasswordEntry.Text == "123")
            {

                PopupMessage.Text = $"¡Bienvenido, {email}!";
                PopupMessage.TextColor = Colors.Green;
                PopupMessage.IsVisible = true;

                await Task.Delay(3000);

                PopupMessage.IsVisible = false;

                await DisplayAlert("Inicio de sesión", "Inicio de sesión exitoso. Redirigiendo al menú...", "OK");

                await Navigation.PushAsync(new MenuPage());
            }
            else
            {
                string errorMessage = "Por favor, corrija los siguientes errores:\n";
                if (!isEmailValid)
                    errorMessage += "- El correo electrónico no tiene un formato válido.\n";
                if (!isPasswordValid)
                    errorMessage += "- La contraseña no puede estar vacía.\n";
                if (isEmailValid && isPasswordValid && (email != "admin" || password != "123"))
                    errorMessage += "- Credenciales incorrectas.";

                PopupMessage.Text = errorMessage;
                PopupMessage.TextColor = Colors.Red;
                PopupMessage.IsVisible = true;

                await Task.Delay(3000);

                PopupMessage.IsVisible = false;

                EmailEntry.Text = string.Empty;
                PasswordEntry.Text = string.Empty;
            }
        }

        private void OnCloseClicked(object sender, EventArgs e)
        {
            Application.Current.Quit(); 
        }
    }
}
