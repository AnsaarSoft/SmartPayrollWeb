namespace SharedLibrary.Models.Administration
{
    public class MstCompany : BaseModel
    {

        [StringLength(50)]
        public string CompanyName { get; set; } = string.Empty;

        [StringLength(50)]
        public string Alias { get; set; } = string.Empty;

        [StringLength(50)]
        public string Region { get; set; } = string.Empty;

        [StringLength(150)]
        public string Email { get; set; } = string.Empty;

        public int Subscription { get; set; }
        public string Status { get; set; } = string.Empty;
    }

}

