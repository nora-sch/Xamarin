﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DemoListes
{
    public class Musique
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int Duree { get; set; }
        public ImageSource Pochette { get; set; }
    }
}
