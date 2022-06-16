using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_LAYOUTS.services;
using Xamarin.Forms;

namespace TP_LAYOUTS
{
    public partial class MainPage : ContentPage
    {
        private services.ITwitterService twitterService = new TwitterService();
        public MainPage()
        {
            InitializeComponent();
            pencilImg.Source = ImageSource.FromResource("TP_LAYOUTS.Ressources.img.pencil.png");
            searchImg.Source = ImageSource.FromResource("TP_LAYOUTS.Ressources.img.search.png");
            respondImg.Source = ImageSource.FromResource("TP_LAYOUTS.Ressources.img.respond.png");
            retweetImg.Source = ImageSource.FromResource("TP_LAYOUTS.Ressources.img.retweet.png");
            favoriteImg.Source = ImageSource.FromResource("TP_LAYOUTS.Ressources.img.favorite.png");
        }

        public void SeConnecter_Clicked(object sender, EventArgs e)
        {
            this.cacherErreur();
            bool errors = false;
            if (this.identifiant.Text == null || string.IsNullOrEmpty(this.identifiant.Text.ToString()) || this.identifiant.Text.ToString().Length < 3)
            {
                this.afficherErreur("Veuillez saisir un identifiant valide!");
                errors = true;
                return;
            }
            if (this.password.Text == null || string.IsNullOrEmpty(this.password.Text.ToString()) || this.password.Text.ToString().Length < 6)
            {
                errors = true;
                this.afficherErreur("Veuillez saisir un mot de passe valide!");
                return;
            }
            if (!errors && this.twitterService.authenticate(this.identifiant.Text, this.password.Text))
            {
                //this.form.IsVisible = false;
                //this.cards.IsVisible = true;
                afficher(cards);
                cacher(form);
            }
            else
            {
                // this.form.IsVisible = true;
                //this.cards.IsVisible = false;
                afficherErreur("Identifiants incorrects");
                afficher(form);
                cacher(cards);
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

        private void cacher(VisualElement objet)
        {
            objet.IsVisible = false;
        }
        private void afficher(VisualElement objet)
        {
            objet.IsVisible = true;
        }

    }
}
