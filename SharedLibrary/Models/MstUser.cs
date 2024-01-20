
namespace SharedLibrary.Models
{
    public class MstUser : BaseModel
    {
        [StringLength(50)]
        public string UserCode { get; set; } = string.Empty;

        [StringLength(100)]
        public string Password { get; set; } = string.Empty;

        public bool UserType { get; set; }
        public int EmployeeID { get; set; }
        public MstUnit Unit { get; set; }
        public MstCompany Company { get; set; }


    }
}
