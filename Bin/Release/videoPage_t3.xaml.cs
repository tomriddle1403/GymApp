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
    public partial class videoPage_t3 : PhoneApplicationPage
    {
        public videoPage_t3()
        {
            InitializeComponent();
        }
        private void P_t3(object sender, RoutedEventArgs e)
        {
            t3.Play();
        }

        private void Pa_t3(object sender, RoutedEventArgs e)
        {
            t3.Pause();
        }

        private void S_t3(object sender, RoutedEventArgs e)
        {
            t3.Stop();
        }
    }
}