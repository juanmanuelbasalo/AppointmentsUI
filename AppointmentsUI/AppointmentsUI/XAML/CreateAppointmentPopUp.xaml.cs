using Rg.Plugins.Popup.Contracts;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppointmentsUI.XAML
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateAppointmentPopUp
    {
        private readonly IPopupNavigation navigation;
        public CreateAppointmentPopUp()
        {
            InitializeComponent();
            navigation = PopupNavigation.Instance;
        }

        private async void CrearCita_Clicked(object sender, EventArgs e)
        {

            await navigation.PopAsync();
        }

        private async void SalirCita_Clicked(object sender, EventArgs e)
        {
            await navigation.PopAsync();
        }

        private void MultiSelect_Clicked(object sender, EventArgs e)
        {

        }
    }
}