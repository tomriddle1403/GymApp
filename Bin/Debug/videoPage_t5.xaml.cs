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
    public partial class videoPage_t5 : PhoneApplicationPage
    {
        public videoPage_t5()
        {
            InitializeComponent();
        }
        private void P_t5(object sender, RoutedEventArgs e)
        {
            t5.Play();
        }

        private void Pa_t5(object sender, RoutedEventArgs e)
        {
            t5.Pause();
        }

        private void S_t5(object sender, RoutedEventArgs e)
        {
            t5.Stop();
        }
    }
}