using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoListes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsMusique : ContentPage
    {
        Musique musique;
        public DetailsMusique(Musique musique)
        {
            InitializeComponent();
            this.musique = musique;
            this.pochette.Source = this.musique.Pochette;
            this.auteur.Text = this.musique.Auteur;
            this.titre.Text = this.musique.Titre;
            this.duree.Text = this.musique.Duree.ToString();
            getJoke();
        }
        private async void getJoke()
        {
            ChuckNorrisJokeService svc = new ChuckNorrisJokeService();
            ChuckNorrisJoke joke = await svc.GetRandomJokeAsync();
            if(joke != null)
            {
                this.citation.Text = joke.value;
            }
        }
    }
}