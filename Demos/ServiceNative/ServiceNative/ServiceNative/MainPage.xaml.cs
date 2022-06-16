using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ServiceNative
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var ori = DeviceDisplay.MainDisplayInfo.Orientation.ToString();
            switch (ori)
            {
                case "Portrait":
                    this.orientation.Text = "Smartphone en mode portrait";
                    break;
                case "Landscape":
                    this.orientation.Text = "Smartphone en mode landscape";
                    break;
                case "Unknown":
                    this.orientation.Text = "Orientation du spartphone inconnu";
                    break;
            }


        }
        public void Button_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<ITextToSpeech>().Speak(this.texte.Text.ToString());
        }
    }
}
