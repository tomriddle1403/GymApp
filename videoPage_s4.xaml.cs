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
    public partial class videoPage_s4 : PhoneApplicationPage
    {
        public videoPage_s4()
        {
            InitializeComponent();
        }
        private void P_s4(object sender, RoutedEventArgs e)
        {
            s4.Play();
        }

        private void Pa_s4(object sender, RoutedEventArgs e)
        {
            s4.Pause();
        }

        private void S_s4(object sender, RoutedEventArgs e)
        {
            s4.Stop();
        }
    }
}