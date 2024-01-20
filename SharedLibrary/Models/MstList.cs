namespace SharedLibrary.Models
{
    public class MstList : BaseModel
    {
        [StringLength(50)]
        public string Title { get; set; } = string.Empty;

        [StringLength(50)]
        public string Type { get; set; } = string.Empty;

    }
}
