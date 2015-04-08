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
    public partial class videoPage_t1 : PhoneApplicationPage
    {
        public videoPage_t1()
        {
            InitializeComponent();
        }

        private void P_t1(object sender, RoutedEventArgs e)
        {
            t1.Play();
        }

        private void Pa_t1(object sender, RoutedEventArgs e)
        {
            t1.Pause();
        }

        private void S_t1(object sender, RoutedEventArgs e)
        {
            t1.Stop();
        }
    }
}