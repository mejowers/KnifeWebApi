using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace KnifeWebApi.Models {
    public class Knife {

        public int Id { get; set; }
        public string Type { get; set; }
        public string  PatternNumber { get; set; }
        public string Description { get; set; }
        public string YearEra { get; set; }
        public string HandleMaterial { get; set; }
        public string Color { get; set; }
        public string Length { get; set; }
        public int NumberOfBlades { get; set; }

        public int? BrandId { get; set; }
        public virtual Brand Brand { get; set; }

        public virtual ICollection<CostAndSale> CostAndSales { get; set; }



        public Knife() { }

    }
}
