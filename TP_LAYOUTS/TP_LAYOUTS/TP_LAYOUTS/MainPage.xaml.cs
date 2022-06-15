using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TP_LAYOUTS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void SeConnecter_Clicked(object sender, EventArgs e)
        {
            bool errors = false;
            this.cacherErreur();
            if (this.identifiant.Text == null || string.IsNullOrEmpty(this.identifiant.Text.ToString()) || this.identifiant.Text.ToString().Length < 3)
            {
                this.afficherErreur("Veuillez saisir un identifiant valide!");
                errors = true;
                return;
            }
            if (this.password.Text == null || string.IsNullOrEmpty(this.password.Text.ToString()) || this.password.Text.ToString().Length < 6)
            {
                errors = true;
                this.afficherErreur("Veuillez saisir un password valide!");
                return;
            }
            if (!errors)
            {
                this.form.IsVisible = false;
                this.cards.IsVisible = true;
            }
            else
            {
                this.form.IsVisible = true;
                this.cards.IsVisible = false;
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
