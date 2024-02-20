using SharedLibrary.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.ViewModels
{
    public class vmLogin
    {
        public MstUser User { get; set; }
        public MstEmployee? Employee { get; set; }
        public string JwtToken { get; set; }
    }
}
