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
    public partial class videoPage_c3 : PhoneApplicationPage
    {
        public videoPage_c3()
        {
            InitializeComponent();
        }
        private void P_c3(object sender, RoutedEventArgs e)
        {
            c3.Play();
        }

        private void Pa_c3(object sender, RoutedEventArgs e)
        {
            c3.Pause();
        }

        private void S_c3(object sender, RoutedEventArgs e)
        {
            c3.Stop();
        }
    }
}