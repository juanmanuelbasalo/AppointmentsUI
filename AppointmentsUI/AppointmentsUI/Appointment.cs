using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentsUI
{
    public class Appointment
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
    }
}
