using System;
using System.Collections.Generic;
using System.Text;

namespace TP_LAYOUTS.models
{
    public class Tweet
    {
        public string identifiant { get; set; }
        public string dateCreation { get; set; }
        public string texte { get; set; }
        public string nomUser { get; set; }
        public string pseudoUser { get; set; }
        public string identifiantUser { get; set; }
    }
}
