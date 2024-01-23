namespace SharedLibrary.Models.Employee
{
    public class MstEmpDependent : BaseModel
    {
        public MstEmployee Employee { get; set; }

        public MstList Relation { get; set; }

        [StringLength(150)]
        public string Name { get; set; } = string.Empty;

        public DateTime DOB { get; set; }

        [StringLength(50)]
        public string NationalCardNo { get; set; } = string.Empty;
    }
}
