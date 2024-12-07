using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerceApp.Entities
{
    public class Product
    {
        //Scalar Properties
        [Key]
        [StringLength(5)]
        [Column(TypeName = "Char")]
        public string ProductId { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(20)]
        public string Description { get; set; }
        public int? Price { get; set; }//null constraint is applied
        public int? Stock { get; set; }
    }
}