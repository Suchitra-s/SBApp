using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SBApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlphabeticalPage : ContentPage
    {
        

        public AlphabeticalPage()
        {
            InitializeComponent();
            A_Button.IsEnabled = InitialCheckWithLetter("A").Result;
            B_Button.IsEnabled = InitialCheckWithLetter("B").Result;
            C_Button.IsEnabled = InitialCheckWithLetter("C").Result;
            D_Button.IsEnabled = InitialCheckWithLetter("D").Result;
            E_Button.IsEnabled = InitialCheckWithLetter("E").Result;
            F_Button.IsEnabled = InitialCheckWithLetter("F").Result;
            G_Button.IsEnabled = InitialCheckWithLetter("G").Result;
            H_Button.IsEnabled = InitialCheckWithLetter("H").Result;
            I_Button.IsEnabled = InitialCheckWithLetter("I").Result;
            J_Button.IsEnabled = InitialCheckWithLetter("J").Result;
            K_Button.IsEnabled = InitialCheckWithLetter("K").Result;
            L_Button.IsEnabled = InitialCheckWithLetter("L").Result;
            M_Button.IsEnabled = InitialCheckWithLetter("M").Result;
            N_Button.IsEnabled = InitialCheckWithLetter("N").Result;
            O_Button.IsEnabled = InitialCheckWithLetter("O").Result;
            P_Button.IsEnabled = InitialCheckWithLetter("P").Result;
            Q_Button.IsEnabled = InitialCheckWithLetter("Q").Result;
            R_Button.IsEnabled = InitialCheckWithLetter("R").Result;
            S_Button.IsEnabled = InitialCheckWithLetter("S").Result;
            T_Button.IsEnabled = InitialCheckWithLetter("T").Result;
            U_Button.IsEnabled = InitialCheckWithLetter("U").Result;
            V_Button.IsEnabled = InitialCheckWithLetter("V").Result;
            W_Button.IsEnabled = InitialCheckWithLetter("W").Result;
            X_Button.IsEnabled = InitialCheckWithLetter("X").Result;
            Y_Button.IsEnabled = InitialCheckWithLetter("Y").Result;
            Z_Button.IsEnabled = InitialCheckWithLetter("Z").Result;
        }

        private void A_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this,"A"));
            
        }

        private void B_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this, "B"));
        }

        private void C_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this, "C"));
        }

        private void D_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this, "D"));
        }

        private void E_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this, "E"));
        }

        private void F_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this, "F"));
        }

        private void G_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this, "G"));
        }

        private void H_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this, "H"));
        }

        private void I_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this, "I"));

        }

        private void J_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this, "J"));
        }

        private void K_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this, "K"));
        }

        private void L_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this, "L"));
        }

        private void M_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this, "M"));
        }

        private void N_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this, "N"));
        }

        private void O_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this, "O"));
        }

        private void P_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this, "P"));
        }

        private void Q_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this, "Q"));
        }

        private void R_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this, "R"));
        }

        private void S_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this, "S"));
        }

        private void T_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this, "T"));
        }

        private void U_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this, "U"));
        }

        private void V_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this, "V"));
        }

        private void W_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this, "W"));
        }

        private void X_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this, "X"));
        }

        private void Y_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this, "Y"));
        }

        private void Z_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpellItRight(this, "Z"));
        }

        private async Task<bool> InitialCheckWithLetter(string ch)
        {
            List<Word> _words = Common.WordsToLearn.Where(x => x.Name.ToUpper().Substring(0, 1).Equals(ch.ToUpper())).ToList();
            if (_words.Count < 1)
            {
                return false;
            }
            else
                return true;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.White;
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.Black;
            this.Title = "Choose the Alphabet";
        }
    }
}