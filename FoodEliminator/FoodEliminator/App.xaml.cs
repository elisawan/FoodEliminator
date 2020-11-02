using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodEliminator
{
    public partial class App : Application
    {
        public static string FilePath;
        public App()
        {
            InitializeApp();
        }

        public App(string filePath)
        {
            InitializeApp();

            FilePath = filePath;
        }

        public void InitializeApp()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
