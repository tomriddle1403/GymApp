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
    public partial class videoPage_t2 : PhoneApplicationPage
    {
        public videoPage_t2()
        {
            InitializeComponent();
        }
        private void P_t2(object sender, RoutedEventArgs e)
        {
            t2.Play();
        }

        private void Pa_t2(object sender, RoutedEventArgs e)
        {
            t2.Pause();
        }

        private void S_t2(object sender, RoutedEventArgs e)
        {
            t2.Stop();
        }
    }
}