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
    public partial class videoPage_a1 : PhoneApplicationPage
    {
        public videoPage_a1()
        {
            InitializeComponent();
        }
        private void P_a1(object sender, RoutedEventArgs e)
        {
            a1.Play();
        }

        private void Pa_a1(object sender, RoutedEventArgs e)
        {
            a1.Pause();
        }

        private void S_a1(object sender, RoutedEventArgs e)
        {
            a1.Stop();
        }
    }
}