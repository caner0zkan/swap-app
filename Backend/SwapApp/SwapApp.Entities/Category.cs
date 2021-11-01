using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SwapApp.Entities
{
    public class Category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public List<Product> Products { get; set; }


        //Foreign Keys
    }
}
