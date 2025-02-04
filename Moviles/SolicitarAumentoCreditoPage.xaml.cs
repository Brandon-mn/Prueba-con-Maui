using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;
using System;

namespace UX_DesignMaui
{
    public partial class SolicitarAumentoCreditoPage : ContentPage
    {
        public SolicitarAumentoCreditoPage()
        {
            InitializeComponent();
        }

        // Subir archivo PDF
        private async void UploadPDF_Click(object sender, EventArgs e)
        {
            var result = await FilePicker.PickAsync(new PickOptions
            {
                FileTypes = FilePickerFileType.Pdf,
            });

            if (result != null)
            {
                PDFFileName.Text = result.FileName;
                PDFFileDisplay.IsVisible = true;
            }
        }

        // Subir imagen
        private async void UploadImage_Click(object sender, EventArgs e)
        {
            var result = await FilePicker.PickAsync(new PickOptions
            {
                FileTypes = FilePickerFileType.Images,
            });

            if (result != null)
            {
                ImageFileName.Text = result.FileName;
                ImageFileDisplay.IsVisible = true;
            }
        }

        // Remover archivo PDF
        private void RemovePDF_Click(object sender, EventArgs e)
        {
            PDFFileDisplay.IsVisible = false;
            PDFFileName.Text = string.Empty;
        }

        // Remover imagen
        private void RemoveImage_Click(object sender, EventArgs e)
        {
            ImageFileDisplay.IsVisible = false;
            ImageFileName.Text = string.Empty;
        }

        // Solicitar aumento de crédito
        private async void SolicitarAumento_Click(object sender, EventArgs e)
        {
            if (PDFFileDisplay.IsVisible && ImageFileDisplay.IsVisible)
            {
                await DisplayAlert("Solicitud en proceso", "Su solicitud de aumento de crédito se procesará, y se le notificará el resultado.", "OK");
            }
            else
            {
                await DisplayAlert("Archivos requeridos", "Por favor, suba ambos archivos requeridos antes de solicitar el aumento de crédito.", "OK");
            }
        }
    }
}
