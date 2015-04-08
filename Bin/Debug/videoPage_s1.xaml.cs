using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Mobile_final
{
    public partial class videoPage_s1 : PhoneApplicationPage
    {
        public videoPage_s1()
        {
            InitializeComponent();
        }

        private void P_s1(object sender, RoutedEventArgs e)
        {
            s1.Play();
        }

        private void Pa_s1(object sender, RoutedEventArgs e)
        {
            s1.Pause();
        }

        private void S_s1(object sender, RoutedEventArgs e)
        {
            s1.Stop();
        }
    }
}