namespace SharedLibrary.Models.Employee.Master
{
    public class MstBankBranch : BaseModel
    {
        [StringLength(50)]
        public string Title { get; set; } = string.Empty;

        public MstBank Bank { get; set; }

        public MstUnit Unit { get; set; }

        public MstCompany Company { get; set; }
    }
}
