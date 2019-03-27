using Rg.Plugins.Popup.Contracts;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamForms.Controls;

namespace AppointmentsUI.XAML
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateAppointment : ContentPage
	{
        private readonly IPopupNavigation navigation;
        public CreateAppointment ()
		{
			InitializeComponent ();
            navigation = PopupNavigation.Instance;
            calendar.DateClicked += PushPopUp;
		}
        private async void PushPopUp(object sender, DateTimeEventArgs e) => await navigation.PushAsync(new CreateAppointmentPopUp());

    }
}