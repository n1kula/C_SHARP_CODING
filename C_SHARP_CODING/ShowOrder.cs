using System;
using System.Collections.Generic;

namespace C_SHARP_CODING
{
    public class ShowOrder
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public List<ShowOrderItems> ShowOrderItems { get; set; }
        public int OrderId { get; set; }
        public Address DeliveryAddress { get; set; }
    }
}
