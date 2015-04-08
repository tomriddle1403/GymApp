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
    public partial class videoPage_a2 : PhoneApplicationPage
    {
        public videoPage_a2()
        {
            InitializeComponent();
        }
        private void P_a2(object sender, RoutedEventArgs e)
        {
            a2.Play();
        }

        private void Pa_a2(object sender, RoutedEventArgs e)
        {
            a2.Pause();
        }

        private void S_a2(object sender, RoutedEventArgs e)
        {
            a2.Stop();
        }
    }
}