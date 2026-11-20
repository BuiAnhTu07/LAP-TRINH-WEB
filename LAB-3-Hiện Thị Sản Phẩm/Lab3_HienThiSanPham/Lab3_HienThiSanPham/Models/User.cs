using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Lab3_HienThiSanPham.Models;

[Table("User")]
public partial class User
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [StringLength(50)]
    public string? Email { get; set; }

    [StringLength(50)]
    public string? Fullname { get; set; }

    [StringLength(50)]
    public string? Password { get; set; }

    [Column("isAdmin")]
    public bool? IsAdmin { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RegisterData { get; set; }

    [StringLength(50)]
    public string? RecoveryCode { get; set; }
}
