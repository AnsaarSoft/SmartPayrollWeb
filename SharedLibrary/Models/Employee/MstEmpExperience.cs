namespace SharedLibrary.Models.Employee
{
    public class MstEmpExperience : BaseModel
    {
        public MstEmployee Employee { get; set; }

        [StringLength(100)]
        public string OrgName { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
