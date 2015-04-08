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
    public partial class videoPage_s3 : PhoneApplicationPage
    {
        public videoPage_s3()
        {
            InitializeComponent();
        }
        private void P_s3(object sender, RoutedEventArgs e)
        {
            s3.Play();
        }

        private void Pa_s3(object sender, RoutedEventArgs e)
        {
            s3.Pause();
        }

        private void S_s3(object sender, RoutedEventArgs e)
        {
            s3.Stop();
        }
    }
}