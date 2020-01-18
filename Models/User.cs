using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRSNetWeb.Models {
    public class User {
        public int Id { get; set; }
        [StringLength(30)] //attributes that tell SQL how to handle data
        [Required]
        public string Username { get; set; }
        [StringLength(30)]
        [Required]
        public string Password { get; set; }
        [StringLength(30)]
        public string FirstName { get; set; }
        [StringLength(30)]
        public string LastName { get; set; }
        [StringLength(12)]
        public string PhoneNumber { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        public bool Admin { get; set; } = false;
        public bool Reviewer { get; set; } = false;

        public User() {

        }
    }
}
