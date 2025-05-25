namespace OwnersAssociationUI.UserControls
{
    partial class TenantListUserControl
    {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraGrid.GridControl gridControlTenants;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTenants;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControlTenants = new DevExpress.XtraGrid.GridControl();
            this.gridViewTenants = new DevExpress.XtraGrid.Views.Grid.GridView();

            ((System.ComponentModel.ISupportInitialize)(this.gridControlTenants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTenants)).BeginInit();

            // 
            // gridControlTenants
            // 
            this.gridControlTenants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTenants.MainView = this.gridViewTenants;
            this.gridControlTenants.Name = "gridControlTenants";
            this.gridControlTenants.Size = new System.Drawing.Size(800, 450);
            this.gridControlTenants.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTenants});

            // 
            // gridViewTenants
            // 
            this.gridViewTenants.GridControl = this.gridControlTenants;
            this.gridViewTenants.Name = "gridViewTenants";

            // 
            // TenantListUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlTenants);
            this.Name = "TenantListUserControl";
            this.Size = new System.Drawing.Size(800, 450);

            ((System.ComponentModel.ISupportInitialize)(this.gridControlTenants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTenants)).EndInit();
        }

        #endregion
    }
}
