using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KnifeWebApi.Models {
    public class Brand {

        public int Id { get; set; }

        [StringLength(75), Required]
        public string Name { get; set; }

        [StringLength(25)]
        public string OriginCountry { get; set; }

        
        public Brand() { }
    }
}
