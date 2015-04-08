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
    public partial class videoPage_s5 : PhoneApplicationPage
    {
        public videoPage_s5()
        {
            InitializeComponent();
        }
        private void P_s5(object sender, RoutedEventArgs e)
        {
            s5.Play();
        }

        private void Pa_s5(object sender, RoutedEventArgs e)
        {
            s5.Pause();
        }

        private void S_s5(object sender, RoutedEventArgs e)
        {
            s5.Stop();
        }
        
    }
   
}