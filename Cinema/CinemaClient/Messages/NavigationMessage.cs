﻿using System;
using GalaSoft.MvvmLight;

namespace CinemaClient.Messages;

public class NavigationMessage
{
    public Type ViewModelType { get; set; }
}