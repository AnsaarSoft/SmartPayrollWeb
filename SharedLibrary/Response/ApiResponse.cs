using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Response
{
    public class ApiResponse
    {
        public bool Success { get; set; }
        public string message { get; set; }
        public string Error { get; set; }
        public object Data { get; set; }
    }
}
