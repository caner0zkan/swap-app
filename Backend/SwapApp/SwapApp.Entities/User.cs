using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwapApp.Entities
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(20)]
        public string Username { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [StringLength(30)]
        public string Surname { get; set; }
        [StringLength(30)]
        public string Email { get; set; }
        [StringLength(150)]
        public string Image { get; set; }
        [StringLength(30)]
        public string Password { get; set; }
        [StringLength(15)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string Adress { get; set; }

        public List<Product> Products { get; set; }


        //Foreign Keys

    }
}
