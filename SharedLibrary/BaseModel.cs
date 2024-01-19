
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary
{
    public class BaseModel
    {
        [Key]
        [Column("Id", Order =1) ]
        public int Id { get; set; }
        [Column("flgActive", Order = 498)]
        public bool flgActive { get; set; } = true;
        [Column("flgDelete", Order = 499)]
        public bool flgDelete { get; set; } = false;
        [StringLength(50)]
        [Column("CreatedBy", Order = 500)]
        public string CreatedBy { get; set; } = string.Empty;
        [StringLength(50)]
        [Column("UpdatedBy", Order = 501)]
        public string UpdatedBy { get; set; } = string.Empty;
        [Column("CreatedDate", Order = 502)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [Column("UpdatedDate", Order = 503)]
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
        [StringLength(150)]
        [Column("cAppStamp", Order = 504)]
        public string cAppStamp { get; set; } = string.Empty;
        [StringLength(150)]
        [Column("uAppStamp", Order = 505)]
        public string uAppStamp { get; set; } = string.Empty;
    }
}
