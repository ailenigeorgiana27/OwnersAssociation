using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using OwnersAssociationCore.Models;
using OwnersAssociationCore.Repositories;

namespace OwnersAssociationUI.UserControls
{
    public partial class TenantListUserControl : XtraUserControl
    {
        
        private readonly string connectionString = "Data Source=PC\\SQLEXPRESS;Database=OwnersAssociation;Integrated Security=true";

        public TenantListUserControl()
        {
            InitializeComponent();
            LoadTenants();
        }

        private void LoadTenants()
        {
            ITenantRepository repo = new TenantRepository(connectionString);
            List<Tenant> tenants = repo.GetAllTenants();
            gridControlTenants.DataSource = tenants;
            ConfigureGridView();
        }

        private void ConfigureGridView()
        {
            gridViewTenants.OptionsBehavior.Editable = false;
            gridViewTenants.OptionsView.ShowAutoFilterRow = true;
            gridViewTenants.OptionsSelection.EnableAppearanceFocusedRow = true;

            gridViewTenants.Columns["Id"].Visible = false;
            gridViewTenants.Columns["InsDt"].Visible = false;
            gridViewTenants.Columns["InsUsrId"].Visible = false;

            gridViewTenants.Columns["FirstName"].Caption = "First Name";
            gridViewTenants.Columns["LastName"].Caption = "Last Name";
            gridViewTenants.Columns["StairCaseId"].Caption = "Staircase";
        }

        
    }
}
