using System;
using System.Collections.Generic;
using System.Text;

namespace SignalR.EntityLayer.Entities
{
    internal class Contact
    {
        public int ContactId { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string FooterDescription { get; set; }
    }
}
