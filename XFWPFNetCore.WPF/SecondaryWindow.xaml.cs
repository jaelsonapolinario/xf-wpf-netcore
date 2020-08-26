﻿using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

namespace XFWPFNetCore.WPF
{
    /// <summary>
    /// Interaction logic for SecondaryWindow.xaml
    /// </summary>
    public partial class SecondaryWindow : FormsApplicationPage
    {
        public SecondaryWindow()
        {
            InitializeComponent();
            Forms.Init();
            LoadApplication(new XFWPFNetCore.App());
        }
    }
}
