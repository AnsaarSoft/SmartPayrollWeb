
namespace SharedLibrary.Models
{
    public class MstUser : BaseModel
    {
        [StringLength(50)]
        public string UserCode { get; set; } = string.Empty;
        [StringLength(100)]
        public string Password { get; set; } = string.Empty;
        [StringLength(150)]
        public string Email { get; set; } = string.Empty;
        [StringLength(10)]
        public string UserType { get; set; } = string.Empty;


    }
}
