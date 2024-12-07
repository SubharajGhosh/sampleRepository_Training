using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerceApp.Entities
{
    public class Order
    {
        [Key]
        [StringLength(5)]
        [Column(TypeName = "Char")]
        public string OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int Qty { get; set; }
        [ForeignKey("ProductNavigation")]
        public string ProductId { get; set; }

        //Navigation Property
        public Product ProductNavigation { get; set; }

    }
}