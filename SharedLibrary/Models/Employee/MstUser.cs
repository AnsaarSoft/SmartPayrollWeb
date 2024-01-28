

using System.Text.Json.Serialization;

namespace SharedLibrary.Models.Employee
{
    public class MstUser : BaseModel
    {
        [Column("UserCode", Order = 2), StringLength(50), Required, JsonPropertyOrder(2)]
        public string UserCode { get; set; } = string.Empty;
        
        [Column("Password", Order = 3), StringLength(100), Required, PasswordPropertyText,JsonPropertyOrder(3)]
        public string Password { get; set; } = string.Empty;
        
        [Column("Email", Order = 4), StringLength(150), Required, EmailAddress, JsonPropertyOrder(4)]
        public string Email { get; set; } = string.Empty;
        
        [Column("UserType", Order = 5), Required, JsonPropertyOrder(5)]
        public UInt16 UserType { get; set; } //1 = super user 2 = super but company level 3 = mss user 4 = ess user

        [Column("FKEmployee", Order = 6), JsonPropertyOrder(6)]
        public MstEmployee? Employee { get; set; }

        [Column("FKUnit", Order = 7), JsonPropertyOrder(7)]
        public MstUnit? Unit { get; set; }

        [Column("FKCompany", Order = 8), JsonPropertyOrder(8)]
        public MstCompany? Company { get; set; }


    }
}
