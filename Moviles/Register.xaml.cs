using System;
using System.Text.RegularExpressions;

namespace Moviles
{
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            string password = PasswordEntry.Text;
            string confirmPassword = PasswordEntry2.Text;
            string email = EmailEntry.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                await DisplayAlert("Error de Registro", "Por favor, rellene todos los campos.", "OK");
                return; 
            }

            bool isPasswordValid =
                password.Length >= 8 &&
                Regex.IsMatch(password, @"[A-Z]") &&
                Regex.IsMatch(password, @"[!@#$%^&*(),.?""{}|<>]");

            bool isEmailValid = Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            if (password != confirmPassword)
            {
                await DisplayAlert("Error de Registro", "Las contraseñas no coinciden.", "OK");
                return;
            }

            if (!isPasswordValid || !isEmailValid)
            {
                string errorMessage = "Por favor, corrija los siguientes errores:\n";
                if (!isPasswordValid)
                    errorMessage += "- La contraseña no cumple con los requisitos (mínimo 8 caracteres, una mayúscula y un carácter especial).\n";
                if (!isEmailValid)
                    errorMessage += "- El correo electrónico no tiene un formato válido.";

                await DisplayAlert("Error de Registro", errorMessage, "OK");
                return;
            }

            await DisplayAlert("Registro", "Usuario registrado correctamente", "OK");
            await Navigation.PushAsync(new Register());
            Navigation.RemovePage(this);
        }


        private async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void OnPasswordTextChanged(object sender, TextChangedEventArgs e)
        {
            string password = e.NewTextValue;

            MinLengthLabel.TextColor = password.Length >= 8 ? Colors.Green : Colors.Red;
            UpperCaseLabel.TextColor = Regex.IsMatch(password, @"[A-Z]") ? Colors.Green : Colors.Red;
            SpecialCharLabel.TextColor = Regex.IsMatch(password, @"[!@#$%^&*(),.?""{}|<>]") ? Colors.Green : Colors.Red;
        }
    }
}
