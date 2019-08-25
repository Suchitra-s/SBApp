using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SBApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.White;
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.Black;
            this.Title = "Spell Bee International Preparation";
            Common.InitializeWords();
        }



        private void SpellItRight_Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AlphabeticalPage());
        }

        private void WordMeanings_Click(object sender, EventArgs e)
        {

        }
    }
}
