namespace SharedLibrary.Models.Employee
{
    public class MstEmpEducation : BaseModel
    {
        public MstEmployee Employee { get; set; }

        [StringLength(100)]
        public string InstName { get; set; } = string.Empty;

        [StringLength(100)]
        public string DegreeName { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
