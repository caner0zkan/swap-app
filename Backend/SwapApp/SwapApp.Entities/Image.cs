using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SwapApp.Entities
{
    public class Image
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Img { get; set; }


        //Foreign Keys
        public int ProductdID { get; set; }
        public Product Product { get; set; }
    }
}
