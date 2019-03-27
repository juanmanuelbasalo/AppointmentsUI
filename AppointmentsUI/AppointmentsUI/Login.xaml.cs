using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppointmentsUI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        private string[] quotesString = new []{ "Holaaaa", "Chaooooo", "ajaaaa", "isncidnvkdnvkdnvkdndk", "sknskdnskdnks"};
        private int numberClicks = 0;
        public Login()
        {
            InitializeComponent();
            quotes.Text = quotesString[numberClicks];
        }

        private void IncreaseFont_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var newValue = Math.Round(e.NewValue/1.0);
            increaseFont.Value = newValue;
        }

        private void NextQuote_Clicked(object sender, EventArgs e)
        {
            if (++numberClicks >= quotesString.Length)
                numberClicks = 0;

            quotes.Text = quotesString[numberClicks];
        }
    }
}