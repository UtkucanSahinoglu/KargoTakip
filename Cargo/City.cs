using System;
using System.Collections.Generic;
using System.Text;

namespace Cargo
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<Address>? Addresses { get; set; }
        public virtual IEnumerable<District>? District { get; set; }
    }
}
