using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Diagnostics.Debug;

namespace AppLifecycleTutorial
{
    public partial class App : Application
    {
        const string displayText = "displayText";

        public string DisplayText { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            WriteLine("OnStart");

            if (Properties.ContainsKey(displayText))
            {
                DisplayText = (string)Properties[displayText];
            }
        }

        protected override void OnSleep()
        {
            WriteLine("OnSleep");
            Properties[displayText] = DisplayText;
        }

        protected override void OnResume()
        {
            WriteLine("OnResume");
        }
    }
}
