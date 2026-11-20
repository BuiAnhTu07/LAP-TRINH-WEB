using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Lab3_HienThiSanPham.Models;

[Keyless]
[Table("Product")]
public partial class Product
{
    [Column("id")]
    public int Id { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [Column(TypeName = "money")]
    public decimal? Price { get; set; }

    public int? Quantity { get; set; }

    [Column("image")]
    [StringLength(200)]
    public string? Image { get; set; }
}
