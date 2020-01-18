using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRSNetWeb.Models {
    public class Vendor {
        public int Id { get; set; }
        [StringLength(10)]
        [Required]
        public string Code { get; set; }
        [StringLength(30)]
        [Required]
        public string Name { get; set; }
        [StringLength(30)]
        public string Address { get; set; }
        [StringLength(30)]
        public string City { get; set; }
        [StringLength(2)]
        public string State { get; set; }
        [StringLength(5)]
        public string Zip { get; set; }
        [StringLength(12)]
        public string PhoneNumber { get; set; }
        [StringLength(80)]
        public string Email { get; set; }

        public Vendor() {

        }
    }
}
