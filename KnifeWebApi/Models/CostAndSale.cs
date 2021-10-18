using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KnifeWebApi.Models {
    public class CostAndSale {

        public int Id { get; set; }

        [Required]
        public int KnifeId { get; set; }

        [Column(TypeName = "decimal(11,2)")]
        public decimal BlueBookPrice { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal PaidPrice { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal AskingPrice { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal SellPrice { get; set; }
        
        public decimal Total { get; set; }


        public virtual Knife Knife { get; set; }

        public CostAndSale() { }

    }
}
