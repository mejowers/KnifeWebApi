using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace KnifeWebApi.Models {
    public class Knife {

        public int Id { get; set; }
        [StringLength(25), Required]
        public string Type { get; set; }

        [StringLength(10)]
        public string  PatternNumber { get; set; }

        [StringLength(255), Required]
        public string Description { get; set; }

        [StringLength(10)]
        public string YearEra { get; set; }

        [StringLength(10)]
        public string HandleMaterial { get; set; }

        [StringLength(10)]
        public string Color { get; set; }

        [StringLength(10)]
        public string Length { get; set; }
        public int NumberOfBlades { get; set; }

        public int? BrandId { get; set; }
        public virtual Brand Brand { get; set; }

        public virtual ICollection<CostAndSale> CostAndSales { get; set; }

        public Knife() { }

    }
}
