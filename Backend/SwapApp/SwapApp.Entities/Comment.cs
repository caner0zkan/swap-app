using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SwapApp.Entities
{
    public class Comment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(200)]
        public string Text { get; set; }
        public DateTime Date { get; set; }


        //Foreign Keys
        public int UserID { get; set; }
        public User User { get; set; }

        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
