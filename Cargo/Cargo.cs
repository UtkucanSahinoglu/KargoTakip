using System;
using System.Collections.Generic;

namespace Cargo
{
    public class Cargo
    {
        public int Id { get; set; }
        public string TrackingNumber { get; set; }
        public string SenderName { get; set; }
        public string RecipientName { get; set; }
        public DateTime SendingDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public string SenderAddress { get; set; }
        public string RecipientAddress { get; set; }

    }
}
