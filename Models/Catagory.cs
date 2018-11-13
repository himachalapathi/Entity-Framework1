using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworork.Models
{[Table("tblCatagories")]
    public class Catagory
    {
        [Key]
       public int CatagoryId { get; set; }
       public string CategoryName { get; set; }

    }
}