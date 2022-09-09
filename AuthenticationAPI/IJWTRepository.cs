using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationAPI
{
    public interface IJWTRepository
    {
       Tokens Authenticate(User users);
    }
}
