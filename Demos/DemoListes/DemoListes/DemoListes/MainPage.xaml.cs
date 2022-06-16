using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoListes
{
    public partial class MainPage : ContentPage
    {
        List<Musique> musiques = new List<Musique>();
        public MainPage()
        {
            InitializeComponent();
            this.musiques.Add(new Musique
            {
                Titre = "Welcome to the Jungle",
                Auteur = "Guns n'Roses",
                Duree = 180,
                Pochette = ImageSource.FromUri(new Uri("https://img.discogs.com/TTvCdOfRi_fxLDTGFnB3oNUCcUo=/fit-in/600x600/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-2599598-1458343786-9998.jpeg.jpg"))});

            this.musiques.Add(new Musique
             {
                 Titre = "Rock You Like a Hurricane",
                 Auteur ="Scorpion",
                 Duree = 180,
                 Pochette = ImageSource.FromUri(new Uri("https://upload.wikimedia.org/wikipedia/en/thumb/b/b6/Rock_You_Like_a_Hurricane_by_Scorpions_European_artwork_German_release.jpeg/220px-Rock_You_Like_a_Hurricane_by_Scorpions_European_artwork_German_release.jpeg"))});
             this.musiques.Add(new Musique
             {
                 Titre = "Kashmir",
                 Auteur = "Led Zeppelin",
                 Duree = 180,
                 Pochette = ImageSource.FromUri(new Uri("https://static.hotmixradio.fr/wp-content/uploads/led-zeppelin-kashmir-live-460x460.jpg"))});
            this.musiques.Add(new Musique
            {
                Titre = "Gimme Shelter",
                Auteur = "The Rolling Stones",
                Duree = 180,
                Pochette = ImageSource.FromUri(new Uri("https://images-na.ssl-images-amazon.com/images/I/51z-MQgpp8L._SY445_.jpg"))});
            this.musiques.Add(new Musique
            {
                Titre = "Back in Black",
                Auteur = "AC/DC",
                Duree = 180,
                Pochette = ImageSource.FromUri(new Uri("https://images-na.ssl-images-amazon.com/images/I/61sJIfuUSiL._SL1500_.jpg"))});
            this.musiques.Add(new Musique
            {
                Titre = "All Along the Watchtower",
                Auteur = "Jimmy Hendrix", 
                Duree = 180, 
                Pochette = ImageSource.FromUri(new Uri("https://img.discogs.com/iZjJevL_oCH-iL7u0jhBWM_v_yw=/fit-in/595x600/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-1740964-1384158788-7761.jpeg.jpg")) });
            this.ListeMusiques.ItemsSource = this.musiques;
        }     
    }
}
