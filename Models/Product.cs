using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworork.Models
{
    [Table("tblProducts")]
    public class Product
    {
        [ForeignKey("Catagory")]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Catagory catagory { get; set; }

    }
}