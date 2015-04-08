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
    public partial class videoPage_a3 : PhoneApplicationPage
    {
        public videoPage_a3()
        {
            InitializeComponent();
        }
        private void P_a3(object sender, RoutedEventArgs e)
        {
            a3.Play();
        }

        private void Pa_a3(object sender, RoutedEventArgs e)
        {
            a3.Pause();
        }

        private void S_a3(object sender, RoutedEventArgs e)
        {
            a3.Stop();
        }
    }
}