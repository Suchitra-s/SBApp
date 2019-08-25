using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.IO;
using System.Xml.Linq;
using System.Reflection;

namespace SBApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpellItRight : ContentPage
    {
        public int Counter = 0;

        public List<Word> _words;
        Page _page = new Page();
        public SpellItRight(Page page, string ch)
        {
            InitializeComponent();
            txtBox.Text = string.Empty;
            _words = new List<Word>();
            GetWords(ch);
            txtblkCounter.Text = "Word " + (Counter+1).ToString() + " of " + _words.Count.ToString();
            _page = page;
        }

        private async void GetWords(string ch)
        {
            _words = Common.WordsToLearn.Where(x => x.Name.ToUpper().Substring(0, 1).Equals(ch.ToUpper())).ToList();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.White;
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.Black;
            this.Title = "Spell It Right";
        }

        private async void btnClick_Click(object sender, EventArgs e)
        {
            TextToSpeech.SpeakAsync(_words[Counter].Name);
           
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var value = txtBox.Text.ToString();
            var word = _words[Counter].Name;
            Counter++;
            if (value.Trim().ToUpper().Equals(word.Trim().ToUpper()))
            {
                    DisplayAlert("Correct", "Good thats correct !! try next word", "OK");
                    txtblkCounter.Text = "Word " + (Counter+1).ToString() + " of " + _words.Count.ToString();
                    txtBox.Text = string.Empty;
            }
            else
            {  
                    DisplayAlert("Sorry", "Sorry !! Correct Answer is : " + word.ToUpper(), "OK");
                    txtblkCounter.Text = "Word " + (Counter+1).ToString() + " of " + _words.Count.ToString();
                    txtBox.Text = string.Empty;
            }
            
            if ((Counter) == _words.Count)
            {
                DisplayAlert("Success", "Well Done!! You have learnt all the words", "OK");
                txtBox.Text = string.Empty;
                Navigation.PopAsync();
            }
        }

       
    }
}