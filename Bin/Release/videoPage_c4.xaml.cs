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
    public partial class videoPage_c4 : PhoneApplicationPage
    {
        public videoPage_c4()
        {
            InitializeComponent();
        }
        private void P_c4(object sender, RoutedEventArgs e)
        {
            c4.Play();
        }

        private void Pa_c4(object sender, RoutedEventArgs e)
        {
            c4.Pause();
        }

        private void S_c4(object sender, RoutedEventArgs e)
        {
            c4.Stop();
        }
    }
}