using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using OwnersAssociationCore.Repositories;
using OwnersAssociationCore.Models;
using OwnersAssociationCore.Providers;


namespace OwnersAssociationUI.UserControls
{
    public partial class TenantFormUserControl : XtraUserControl
    {
        private string connectionString = "Data Source=PC\\SQLEXPRESS;Database=OwnersAssociation;Integrated Security=true";

        public TenantFormUserControl()
        {
            InitializeComponent();
            LoadStaircases();
        }

        private void LoadStaircases()
        {
            using (SqlConnection conn = SqlProvider.OpenSqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Code + ' - ' + Description AS Name FROM Staircases", conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                lookUpEditStaircase.Properties.DataSource = table;
                lookUpEditStaircase.Properties.DisplayMember = "Name";
                lookUpEditStaircase.Properties.ValueMember = "Id";
                lookUpEditStaircase.Properties.NullText = "Select Staircase";
            }
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            var tenant = new Tenant
            {
                FirstName = textEditFirstName.Text,
                LastName = textEditLastName.Text,
                InsDt = DateTime.Now,
                InsUsrId = 1 // hardcoded for now
            };

            if (lookUpEditStaircase.EditValue is int staircaseId)
                tenant.StairCaseId = staircaseId;

            // Call AddTenant repository method
            var repo = new TenantRepository(connectionString);
            repo.AddTenant(tenant);

            XtraMessageBox.Show("Tenant saved successfully!");
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            // Close parent form if it's hosted inside one
            FindForm()?.Close();
        }
    }
}