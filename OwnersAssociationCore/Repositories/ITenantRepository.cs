using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OwnersAssociationCore.Models;

namespace OwnersAssociationCore.Repositories
{
    public interface ITenantRepository
    {
        void AddTenant(Tenant tenant);
        List<Tenant> GetAllTenants();
    }
}
