namespace SharedLibrary.Models.Employee.Master
{
    public class MstCity : BaseModel
    {
        [StringLength(50)]
        public string Title { get; set; } = string.Empty;

        public MstCountry Country { get; set; } = new MstCountry();
    }
}
