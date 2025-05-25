using System;
using System.Windows.Forms;
using OwnersAssociationUI.UserControls;

namespace OwnersAssociationManagement
{
    public partial class MainForm : Form
    {
        private Button buttonAddTenant;
        private Button buttonListTenants;
        private Panel contentPanel;

        public MainForm()
        {
            InitializeComponent();
            SetupLayout(); 
        }

        private void SetupLayout()
        {
            this.buttonAddTenant = new Button();
            this.buttonListTenants = new Button();
            this.contentPanel = new Panel();

            // MainForm
            this.Text = "Owners Association Management";
            this.ClientSize = new System.Drawing.Size(900, 600);

            // buttonAddTenant
            this.buttonAddTenant.Text = "Add Tenant";
            this.buttonAddTenant.Location = new System.Drawing.Point(10, 10);
            this.buttonAddTenant.Size = new System.Drawing.Size(100, 30);
            this.buttonAddTenant.Click += new EventHandler(this.ButtonAddTenant_Click);

            // buttonListTenants
            this.buttonListTenants.Text = "List Tenants";
            this.buttonListTenants.Location = new System.Drawing.Point(120, 10);
            this.buttonListTenants.Size = new System.Drawing.Size(100, 30);
            this.buttonListTenants.Click += new EventHandler(this.ButtonListTenants_Click);

            // contentPanel
            this.contentPanel.Location = new System.Drawing.Point(10, 50);
            this.contentPanel.Size = new System.Drawing.Size(880, 540);
            this.contentPanel.BorderStyle = BorderStyle.FixedSingle;

            // Add controls to form
            this.Controls.Add(this.buttonAddTenant);
            this.Controls.Add(this.buttonListTenants);
            this.Controls.Add(this.contentPanel);
        }

        private void ButtonAddTenant_Click(object sender, EventArgs e)
        {
            LoadControl(new TenantFormUserControl());
        }

        private void ButtonListTenants_Click(object sender, EventArgs e)
        {
            LoadControl(new TenantListUserControl());
        }

        private void LoadControl(Control control) 
        {
            contentPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(control);
        }
    }
}
