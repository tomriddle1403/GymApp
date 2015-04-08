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
    public partial class videoPage_c2 : PhoneApplicationPage
    {
        public videoPage_c2()
        {
            InitializeComponent();
        }
        private void P_c2(object sender, RoutedEventArgs e)
        {
            c2.Play();
        }

        private void Pa_c2(object sender, RoutedEventArgs e)
        {
            c2.Pause();
        }

        private void S_c2(object sender, RoutedEventArgs e)
        {
            c2.Stop();
        }
    }
}