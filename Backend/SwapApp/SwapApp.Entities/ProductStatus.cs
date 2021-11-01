using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SwapApp.Entities
{
    public class ProductStatus
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Status { get; set; }

        public List<Product> Products { get; set; }


        //Foreign Keys
    }
}
