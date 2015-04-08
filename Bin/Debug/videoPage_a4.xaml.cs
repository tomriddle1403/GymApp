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
    public partial class videoPage_a4 : PhoneApplicationPage
    {
        public videoPage_a4()
        {
            InitializeComponent();
        }

        private void P_a4(object sender, RoutedEventArgs e)
        {
            a4.Play();
        }

        private void Pa_a4(object sender, RoutedEventArgs e)
        {
            a4.Pause();
        }

        private void S_a4(object sender, RoutedEventArgs e)
        {
            a4.Stop();
        }

       
    }
}