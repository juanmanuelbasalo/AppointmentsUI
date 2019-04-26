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
	public partial class CheckAppointment : ContentPage
	{
		public CheckAppointment ()
		{
			InitializeComponent ();

            listAppointments.ItemsSource = new List<Appointment>
            {
                new Appointment{ Name = "Recoger Ropa", Description = "Recoger 5 franelas", Status = "Activo", Date = new DateTime(2019,2,28,22,25,0)},
                new Appointment{ Name = "Recoger Ropa 2", Description = "Recoger 5 franelas 2", Status = "Activo2", Date = new DateTime(2019,1,18,22,25,0)},
            };
		}
	}
}