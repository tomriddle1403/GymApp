using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Mobile_final.Resources;
using Windows.Phone.Speech.Synthesis;

namespace Mobile_final
{
    public partial class lessonPage : PhoneApplicationPage
    {
        public lessonPage()
        {
            InitializeComponent();
        }

    //abdonimals
        private async void bt_a1(object sender, RoutedEventArgs e)
        {
            
            NavigationService.Navigate(new Uri("/videoPage_a1.xaml", UriKind.Relative));
            SpeechSynthesizer synth = new SpeechSynthesizer();
            await synth.SpeakTextAsync("Lesson1");

        }

        private async void bt_a2(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/videoPage_a2.xaml", UriKind.Relative));
            SpeechSynthesizer synth = new SpeechSynthesizer();
            await synth.SpeakTextAsync("Lesson2");

        }
        private async void bt_a3(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/videoPage_a3.xaml", UriKind.Relative));
            SpeechSynthesizer synth = new SpeechSynthesizer();
            await synth.SpeakTextAsync("Lesson3");

        }
        private async void bt_a4(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/videoPage_a4.xaml", UriKind.Relative));
            SpeechSynthesizer synth = new SpeechSynthesizer();
            await synth.SpeakTextAsync("Lesson4");

        }
        private async void bt_a5(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/videoPage_a5.xaml", UriKind.Relative));
            SpeechSynthesizer synth = new SpeechSynthesizer();
            await synth.SpeakTextAsync("Lesson5");

        }
      //chest
        private async void bt_c1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/videoPage_c1.xaml", UriKind.Relative));
            SpeechSynthesizer synth = new SpeechSynthesizer();
            await synth.SpeakTextAsync("Lesson1");
        }
        private async void bt_c2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/videoPage_c2.xaml", UriKind.Relative));
            SpeechSynthesizer synth = new SpeechSynthesizer();
            await synth.SpeakTextAsync("Lesson2");
        }
        private async void bt_c3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/videoPage_c3.xaml", UriKind.Relative));
            SpeechSynthesizer synth = new SpeechSynthesizer();
            await synth.SpeakTextAsync("Lesson3");
        }
        private async void bt_c4(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/videoPage_c4.xaml", UriKind.Relative));
            SpeechSynthesizer synth = new SpeechSynthesizer();
            await synth.SpeakTextAsync("Lesson4");
        }
        private async void bt_c5(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/videoPage_c5.xaml", UriKind.Relative));
            SpeechSynthesizer synth = new SpeechSynthesizer();
            await synth.SpeakTextAsync("Lesson5");
        }
    //shoulder
        private async void bt_s1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/videoPage_s1.xaml", UriKind.Relative));
            SpeechSynthesizer synth = new SpeechSynthesizer();
            await synth.SpeakTextAsync("Lesson1");
        }
        private async void bt_s2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/videoPage_s2.xaml", UriKind.Relative));
            SpeechSynthesizer synth = new SpeechSynthesizer();
            await synth.SpeakTextAsync("Lesson2");
        }
        private async void bt_s3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/videoPage_s3.xaml", UriKind.Relative));
            SpeechSynthesizer synth = new SpeechSynthesizer();
            await synth.SpeakTextAsync("Lesson3");
        }
        private async void bt_s4(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/videoPage_s4.xaml", UriKind.Relative));
            SpeechSynthesizer synth = new SpeechSynthesizer();
            await synth.SpeakTextAsync("Lesson4");
        }
        private async void bt_s5(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/videoPage_s5.xaml", UriKind.Relative));
            SpeechSynthesizer synth = new SpeechSynthesizer();
            await synth.SpeakTextAsync("Lesson5");
        }

      //triceps
        private async void bt_t1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/videoPage_t1.xaml", UriKind.Relative));
            SpeechSynthesizer synth = new SpeechSynthesizer();
            await synth.SpeakTextAsync("Lesson1");
        }
        private async void bt_t2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/videoPage_t2.xaml", UriKind.Relative));
            SpeechSynthesizer synth = new SpeechSynthesizer();
            await synth.SpeakTextAsync("Lesson2");
        }
        private async void bt_t3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/videoPage_t3.xaml", UriKind.Relative));
            SpeechSynthesizer synth = new SpeechSynthesizer();
            await synth.SpeakTextAsync("Lesson3");
        }
        private async void bt_t4(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/videoPage_t4.xaml", UriKind.Relative));
            SpeechSynthesizer synth = new SpeechSynthesizer();
            await synth.SpeakTextAsync("Lesson4");
        }
        private async void bt_t5(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/videoPage_t5.xaml", UriKind.Relative));
            SpeechSynthesizer synth = new SpeechSynthesizer();
            await synth.SpeakTextAsync("Lesson5");
        }

       
        

       
    }
}