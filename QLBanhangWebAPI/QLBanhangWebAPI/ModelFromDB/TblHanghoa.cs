﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QLBanhangWebAPI.ModelFromDB
{
    [Table("tblHanghoa")]
    public partial class TblHanghoa
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column("MA")]
        [StringLength(50)]
        public string? Ma { get; set; }
        [Column("TEN")]
        [StringLength(250)]
        public string? Ten { get; set; }
        [Column("DONVI")]
        [StringLength(10)]
        public string? Donvi { get; set; }
        [Column("GIANHAP")]
        public double? Gianhap { get; set; }
        [Column("GIABAN")]
        public double? Giaban { get; set; }
        [Column("NGUOITAO")]
        public Guid? Nguoitao { get; set; }
        [Column("NGAYTAO", TypeName = "datetime")]
        public DateTime? Ngaytao { get; set; }
    }
}
