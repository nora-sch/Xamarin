﻿using System;
using System.Collections.Generic;
using System.Text;
using TP_LAYOUTS.models;

namespace TP_LAYOUTS.services
{
    internal interface ITwitterService
    {
        bool authenticate(String key, String secret);
        List<Tweet> getTweets();

    }
}
