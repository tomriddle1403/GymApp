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
    public partial class videoPage_s2 : PhoneApplicationPage
    {
        public videoPage_s2()
        {
            InitializeComponent();
        }
        private void P_s2(object sender, RoutedEventArgs e)
        {
            s2.Play();
        }

        private void Pa_s2(object sender, RoutedEventArgs e)
        {
            s2.Pause();
        }

        private void S_s2(object sender, RoutedEventArgs e)
        {
            s2.Stop();
        }
    }
}