using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PRSNetWeb.Models {
    public class Product {
        public int Id { get; set; }
        [StringLength(10)]
        [Required]
        public string PartNumber { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [Column(TypeName="decimal(18,2)")]
        public decimal Price { get; set; } = 10.99m; //hard code a decimal by adding an m
        [StringLength(20)]
        public string Unit { get; set; }
        [StringLength(20)]
        public string PhotoPath { get; set; }

        //define foreign key
        public int VendorId { get; set; } //when another class name is used it says it is a foreign key
        public virtual Vendor Vendor { get; set; } //gets vendor instance, virtual is not in the table, can be nullable

        public Product() {

        }
    }
}
