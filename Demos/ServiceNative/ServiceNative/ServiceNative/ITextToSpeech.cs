﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceNative
{
    public interface ITextToSpeech
    {
        void Speak(string text);
    }
}
