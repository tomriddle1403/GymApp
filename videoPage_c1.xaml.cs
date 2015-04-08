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
    public partial class videoPage_c1 : PhoneApplicationPage
    {
        public videoPage_c1()
        {
            InitializeComponent();
        }

        private void P_c1(object sender, RoutedEventArgs e)
        {
            c1.Play();
        }

        private void Pa_c1(object sender, RoutedEventArgs e)
        {
            c1.Pause();
        }

        private void S_c1(object sender, RoutedEventArgs e)
        {
            c1.Stop();
        }
    }
}