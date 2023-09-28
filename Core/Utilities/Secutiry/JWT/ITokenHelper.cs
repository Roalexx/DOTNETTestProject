using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Secutiry.JWT
{
    internal interface ITokenHelper
    {
        AccessToken CreatToken(User user, List<OperationClaim> operationClaims);
    }
}
