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
    public partial class videoPage_c5 : PhoneApplicationPage
    {
        public videoPage_c5()
        {
            InitializeComponent();
        }
        private void P_c5(object sender, RoutedEventArgs e)
        {
            c5.Play();
        }

        private void Pa_c5(object sender, RoutedEventArgs e)
        {
            c5.Pause();
        }

        private void S_c5(object sender, RoutedEventArgs e)
        {
            c5.Stop();
        }
    }
}