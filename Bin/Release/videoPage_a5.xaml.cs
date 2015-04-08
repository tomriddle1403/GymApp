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
    public partial class videoPage_a5 : PhoneApplicationPage
    {
        public videoPage_a5()
        {
            InitializeComponent();
        }

        private void P_a5(object sender, RoutedEventArgs e)
        {
            a5.Play();
        }

        private void Pa_a5(object sender, RoutedEventArgs e)
        {
            a5.Pause();
            
        }

        private void S_a5(object sender, RoutedEventArgs e)
        {
            a5.Stop();
        }
    }
}