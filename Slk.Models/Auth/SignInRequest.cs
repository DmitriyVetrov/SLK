using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slk.Models.Auth
{
    public class SignInRequest
    {
        public string Email { get; set; }
        public string Pass { get; set; }
    }
}
