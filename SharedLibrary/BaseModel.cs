using System.Text.Json.Serialization;

namespace SharedLibrary
{
    public class BaseModel
    {
        
        [Key, Column("Id", Order =1), JsonPropertyOrder(1) ]
        public int Id { get; set; }
        
        [Column("flgActive", Order = 498), JsonPropertyOrder(498)]
        public bool flgActive { get; set; } = true;
        
        [Column("flgDelete", Order = 499), JsonPropertyOrder(499)]
        public bool flgDelete { get; set; } = false;
        
        [Column("CreatedBy", Order = 500), StringLength(50), JsonPropertyOrder(500)]
        public string CreatedBy { get; set; } = string.Empty;
        
        [Column("UpdatedBy", Order = 501), StringLength(50), JsonPropertyOrder(501)]
        public string UpdatedBy { get; set; } = string.Empty;
        
        [Column("CreatedDate", Order = 502), JsonPropertyOrder(502)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        
        [Column("UpdatedDate", Order = 503), JsonPropertyOrder(503)]
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
        
        [Column("cAppStamp", Order = 504), StringLength(150), JsonPropertyOrder(504)]
        public string cAppStamp { get; set; } = string.Empty;
        
        [Column("uAppStamp", Order = 505), StringLength(150), JsonPropertyOrder(505)]
        public string uAppStamp { get; set; } = string.Empty;
    }
}
