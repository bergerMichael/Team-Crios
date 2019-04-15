using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace GodsOfCalamityBeta
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainMenu : Page
    {
        public MainMenu()
        {
            this.InitializeComponent();

            mainMenu.Height = ScaleToHighDPI((float)ApplicationView.GetForCurrentView().VisibleBounds.Height);
            mainMenu.Width = ScaleToHighDPI((float)ApplicationView.GetForCurrentView().VisibleBounds.Width);

            titleText.Margin = new Thickness(mainMenu.Width * .15, mainMenu.Height * .25, 0, 0);
            logo.Margin = new Thickness(mainMenu.Width / 2 - 100, mainMenu.Height / 2 - 100, 0, 0);
            startGame.Margin = new Thickness(mainMenu.Width / 2 - startGame.Width / 2, mainMenu.Height * .75, 0, 0);

            startGame.Click += StartGame_Click;
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GamePage));
        }

        /// Used to scale to high DPI displays
        private float ScaleToHighDPI(float f)
        {
            Windows.Graphics.Display.DisplayInformation d = Windows.Graphics.Display.DisplayInformation.GetForCurrentView();
            f *= (float)d.RawPixelsPerViewPixel;
            return f;
        }
    }
}
