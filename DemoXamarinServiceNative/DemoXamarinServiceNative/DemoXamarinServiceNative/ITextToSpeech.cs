using System;
using System.Collections.Generic;
using System.Text;

namespace DemoXamarinServiceNative
{
    public interface ITextToSpeech
    {
        void Speak(string text);
    }
}
