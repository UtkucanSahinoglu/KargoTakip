using System;
using System.Collections.Generic;
using System.Text;

namespace Cargo
{
    public class Address
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OpenAddress { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int DistrictId { get; set; }
        public District District { get; set; }
        //public Cargo? Cargo { get; set; }
        public virtual IEnumerable<Cargo>? Cargos { get; set; }
    }
}
