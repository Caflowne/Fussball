using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using mshtml;

namespace Fußball
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //System.Windows.Controls.WebBrowser
        public MainWindow()
        {
            InitializeComponent();
            mth_loadOdds();
        }

        private void mth_loadOdds()
        {
            //webBrowser.Source = new Uri( @"https://www.oddset.de/de/annahmestelle/wettprogramm-plus" );
        }

        private void webBrowser_LoadCompleted(object sender, NavigationEventArgs e)
        {
            Object doc = webBrowser.Document;
            //webBrowser.Navigate("javascript: leagues_select_all(true);");

            //webBrowser.Navigate("http://www.livelivelive.com/livescore.php");
            string s3 = ((HTMLDocument)doc).body.innerText;
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
