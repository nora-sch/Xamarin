using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoXamarinServiceNative
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void Button_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<ITextToSpeech>().Speak(this.texte.Text.ToString());
        }
    }
}
