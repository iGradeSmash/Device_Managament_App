using System;
using System.Collections.Generic;

namespace Device_Management_App.Classes
{
    public partial class Devices
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Barcode { get; set; }
        public bool? Status { get; set; }
    }
}
