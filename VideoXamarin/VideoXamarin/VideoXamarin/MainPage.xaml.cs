using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VideoXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void SeConnecter_Clicked(object sender, EventArgs e)
        {
            this.cacherErreur();
            if (this.email.Text == null || string.IsNullOrEmpty(this.email.Text.ToString()))
            {
                this.afficherErreur("Veuillez saisir un mail valide!");
                return;
            }
            if (this.password.Text == null || string.IsNullOrEmpty(this.password.Text.ToString()) || this.password.Text.ToString().Length<6)
            {
                this.afficherErreur("Veuillez saisir un password valide!");
                return;
            }
            if (this.codePostal.Text == null || string.IsNullOrEmpty(this.codePostal.Text.ToString()) || this.codePostal.Text.ToString().Length < 5)
            {
                this.afficherErreur("Veuillez saisir un code postal valide!");
                return;
            }
            if (this.seSouvenir.IsToggled)
            {
                DisplayAlert("Information", "Vous serez automatiquement connecté au prochain lancement", "Compris");
            }
        }
        private void cacherErreur()
        {
            this.erreur.IsVisible = false;
        }
        private void afficherErreur(string message)
        {
            this.erreur.IsVisible = true;
            this.erreur.Text = message;
        }
    }
}
