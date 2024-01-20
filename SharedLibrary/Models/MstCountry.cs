namespace SharedLibrary.Models
{
    public class MstCountry : BaseModel
    {
        [StringLength(50)]
        public string Title { get; set; } = string.Empty;
    }
}
