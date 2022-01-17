using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_With_WebAPI.Models
{
    public class TokenModel
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
