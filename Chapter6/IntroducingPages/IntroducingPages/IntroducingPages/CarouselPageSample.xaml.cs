﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntroducingPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselPageSample : CarouselPage
    {
        public CarouselPageSample()
        {
            InitializeComponent();
        }
    }
}