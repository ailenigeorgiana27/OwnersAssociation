using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using OwnersAssociationCore.Models;
using OwnersAssociationCore.Repositories;
using OwnersAssociationCore.Providers;

namespace OwnersAssociationCore.Repositories
{
    public class TenantRepository : ITenantRepository
    {
        private readonly string _connectionString;

        public TenantRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddTenant(Tenant tenant)
        {
            using var conn = SqlProvider.OpenSqlConnection(_connectionString);
            var cmd = new SqlCommand("INSERT INTO Tenants (LastName, FirstName, StairCaseId, InsDt, InsUsrId) " +
                                     "VALUES (@LastName, @FirstName, @StairCaseId, @InsDt, @InsUsrId)", conn);
            cmd.Parameters.AddWithValue("@LastName", tenant.LastName);
            cmd.Parameters.AddWithValue("@FirstName", tenant.FirstName);
            cmd.Parameters.AddWithValue(
                "@StairCaseId",
                tenant.StairCaseId.HasValue ? (object)tenant.StairCaseId.Value : DBNull.Value
            );
            cmd.Parameters.AddWithValue("@InsDt", tenant.InsDt ?? DateTime.Now);
            cmd.Parameters.AddWithValue("@InsUsrId", tenant.InsUsrId ?? 1);
            cmd.ExecuteNonQuery();
        }

        public List<Tenant> GetAllTenants()
        {
            var tenants = new List<Tenant>();
            using var conn = SqlProvider.OpenSqlConnection(_connectionString);
            var cmd = new SqlCommand("SELECT Id, FirstName, LastName, StairCaseId, InsDt, InsUsrId FROM Tenants", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tenants.Add(new Tenant
                {
                    Id = reader["Id"] != DBNull.Value ? Convert.ToInt32(reader["Id"]) : (int?)null,
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    StairCaseId = reader["StairCaseId"] != DBNull.Value ? Convert.ToInt32(reader["StairCaseId"]) : (int?)null,
                    InsDt = reader["InsDt"] != DBNull.Value ? Convert.ToDateTime(reader["InsDt"]) : (DateTime?)null,
                    InsUsrId = reader["InsUsrId"] != DBNull.Value ? Convert.ToInt32(reader["InsUsrId"]) : (int?)null
                });
            }
            return tenants;
        }

    }
}
