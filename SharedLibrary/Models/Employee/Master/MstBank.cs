namespace SharedLibrary.Models.Employee.Master
{
    public class MstBank : BaseModel
    {
        [StringLength(50)]
        public string Title { get; set; } = string.Empty;

        public MstUnit Unit { get; set; }

        public MstCompany Company { get; set; }
    }
}
