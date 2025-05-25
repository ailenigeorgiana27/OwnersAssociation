using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnersAssociationCore.Models
{
    public class Tenant
    {
        public int? Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public int? StairCaseId { get; set; }

        public DateTime? InsDt { get; set; }

        public int? InsUsrId { get; set; }
    }
}
