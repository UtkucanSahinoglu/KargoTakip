using System;
using System.Collections.Generic;
using System.Text;

namespace Cargo
{
    public class District
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public virtual IEnumerable<Address>? Addresses { get; set; }
    }
}
