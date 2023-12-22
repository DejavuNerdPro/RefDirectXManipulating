using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RefDirecXManipulate.Entities
{
    [Table("Product")]
    public class Product
    {
        [Column("PID")]
        public int Pid { get; set; }
        [Column("NAME")]
        public string Name { get; set; }
        [Column("PRICE")]
        public decimal Price { get; set; }
        [Column("DISCOUNT")]
        public decimal Discount { get; set; }
    }
}
