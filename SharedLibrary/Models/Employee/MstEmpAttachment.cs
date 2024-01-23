namespace SharedLibrary.Models.Employee
{
    public class MstEmpAttachment : BaseModel
    {
        public MstEmployee Employee { get; set; }

        [StringLength(100)]
        public string FileName { get; set; } = string.Empty;

        [StringLength(500)]
        public string FilePath { get; set; } = string.Empty;

        [StringLength(200)]
        public string Remarks { get; set; } = string.Empty;
    }
}
