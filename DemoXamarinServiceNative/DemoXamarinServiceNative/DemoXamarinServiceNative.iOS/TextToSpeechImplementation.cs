using AVFoundation;
using DemoXamarinServiceNative.iOS;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeechImplementation))]
namespace DemoXamarinServiceNative.iOS
{
    internal class TextToSpeechImplementation : ITextToSpeech
    {
        public void Speak(string text)
        {
            var speechSynthesizer = new AVSpeechSynthesizer();
            var speechUtterance = new AVSpeechUtterance(text);
            speechSynthesizer.SpeakUtterance(speechUtterance);
        }
    }
}