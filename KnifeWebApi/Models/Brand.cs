using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnifeWebApi.Models {
    public class Brand {

        public int Id { get; set; }
        public string Name { get; set; }
        public string OriginCountry { get; set; }

        public virtual IEnumerable<Knife> Knives { get; set; }
    }
}
