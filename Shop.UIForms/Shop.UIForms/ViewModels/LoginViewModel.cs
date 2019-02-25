

namespace Shop.UIForms.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class LoginViewModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public ICommand LoginCommand => new RelayCommand(Login);

        public LoginViewModel()
        {
            this.Email = "orlandoespinosa166321@correo.itm.edu.co";
            this.Password = "123456";
        }

        private async void Login()
        {
            // validación de campo Email, si hay error saca mensajes de error
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an email.",
                    "Accept");
                return;
            }

            // validación de campo de password, si hay error saca mensajes de error
            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter a ´Password.",
                    "Accept");
                return;
            }

            if (!this.Email.Equals("orlandoespinosa166321@correo.itm.edu.co") || !this.Password.Equals("123456"))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "User or password wrong.",
                    "Accept");
                return;
            }

            // Mensaje satisfactorio
            await Application.Current.MainPage.DisplayAlert(
                    "Ok",
                    "Fuck yeah!!!",
                    "Accept");
        }
    }
}
