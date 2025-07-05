using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Tools
{
    public class JwtTokeDefaults
    {
        public const string ValidAudience = "https://localhost";
        public const string ValidIssuer = "https://localhost";
        public const string Key = "CarBook+*010203CARBOOK01+*..020304CARBOOKPROJE";
        public const int Expire = 3;
    }
}
