using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SwapApp.Entities
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(40)]
        public string Title { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(150)]
        public string Image { get; set; }
        public int Price { get; set; }
        [StringLength(50)]
        public string Keywords { get; set; }
        public DateTime Date { get; set; }

        public List<Image> Images { get; set; }
        public List<Bid> Bids { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Product> Offers { get; set; }


        //Foreign Keys
        public int UserID { get; set; }
        public User User { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public int ProductStatusID { get; set; }
        public ProductStatus ProductStatus { get; set; }
    }
}
