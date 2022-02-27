using Identity.DbContexts;
using Identity.Models.DB_Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Repository
{
    public class UserRolesRepository
    {
        public readonly DB_SecurityContext _context;
        public UserRolesRepository(DB_SecurityContext erpContext)
        {
            _context = erpContext;
        }
        public ICollection<TblUserToken> GetUserRoles()
        {
            return _context.TblUserToken.OrderBy(c => c.StrRefreshToken).ToList();
        }
    }
}
