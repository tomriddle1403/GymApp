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
    public partial class videoPage_t4 : PhoneApplicationPage
    {
        public videoPage_t4()
        {
            InitializeComponent();
        }
        private void P_t4(object sender, RoutedEventArgs e)
        {
            t4.Play();
        }

        private void Pa_t4(object sender, RoutedEventArgs e)
        {
            t4.Pause();
        }

        private void S_t4(object sender, RoutedEventArgs e)
        {
            t4.Stop();
        }
    }
}