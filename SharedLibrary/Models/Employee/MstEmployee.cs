namespace SharedLibrary.Models.Employee
{
    public class MstEmployee : BaseModel
    {
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName { get; } = string.Empty;
        public string FatherName { get; set; } = string.Empty;
        public string MotherName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public DateTime? DOB { get; set; }
        public DateTime? ServiceStartDate { get; set; }
        public DateTime? ServiceEndDate { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public string HomeAddress { get; set; } = string.Empty;
        public string HomePhoneNumber { get; set; } = string.Empty;
        public string HomeEmail { get; set; } = string.Empty;
        public string HomeCity { get; set; } = string.Empty;
        public string HomeCountry { get; set; } = string.Empty;
        public string WorkAddress { get; set; } = string.Empty;
        public string WorkPhoneNumber { get; set; } = string.Empty;
        public string WorkEmail { get; set; } = string.Empty;
        public string WorkCity { get; set; } = string.Empty;
        public string WorkCountry { get; set; } = string.Empty;



        public int EmployeeID { get; set; }

        [StringLength(50)]
        public string UserCode { get; set; } = string.Empty;

        [StringLength(100)]
        public string Password { get; set; } = string.Empty;

        public bool UserType { get; set; }

    }
}
