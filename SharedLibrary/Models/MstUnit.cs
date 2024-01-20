namespace SharedLibrary.Models
{
    public class MstUnit : BaseModel
    {
        [StringLength(50)]
        public string UnitName { get; set; } = string.Empty;

        [StringLength(50)]
        public string Alias { get; set; } = string.Empty;

        public int ClientId { get; set; }

        public string Status { get; set; } = string.Empty;

        public int UnitSize { get; set; }

        [StringLength(10)]
        public string Region { get; set; } = string.Empty;

        [StringLength(10)]
        public string Currency { get; set; } = string.Empty;
    }
}
