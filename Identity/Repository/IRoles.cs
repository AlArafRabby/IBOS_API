using Identity.Models.DB_Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Repository
{
    public interface IRoles
    {
        ICollection<TblUserToken> GetUserRoles();
    }
}
