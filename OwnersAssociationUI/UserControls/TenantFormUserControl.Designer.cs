namespace OwnersAssociationUI.UserControls
{
    partial class TenantFormUserControl
    {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditStaircase;
        private DevExpress.XtraEditors.TextEdit textEditFirstName;
        private DevExpress.XtraEditors.TextEdit textEditLastName;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lookUpEditStaircase = new DevExpress.XtraEditors.LookUpEdit();
            this.textEditFirstName = new DevExpress.XtraEditors.TextEdit();
            this.textEditLastName = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();

            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStaircase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLastName.Properties)).BeginInit();

            this.SuspendLayout();

            // lookUpEditStaircase
            this.lookUpEditStaircase.Location = new System.Drawing.Point(20, 20);
            this.lookUpEditStaircase.Name = "lookUpEditStaircase";
            this.lookUpEditStaircase.Size = new System.Drawing.Size(250, 20);
            this.lookUpEditStaircase.TabIndex = 0;

            // textEditFirstName
            this.textEditFirstName.Location = new System.Drawing.Point(20, 60);
            this.textEditFirstName.Name = "textEditFirstName";
            this.textEditFirstName.Size = new System.Drawing.Size(250, 20);
            this.textEditFirstName.TabIndex = 1;

            // textEditLastName
            this.textEditLastName.Location = new System.Drawing.Point(20, 100);
            this.textEditLastName.Name = "textEditLastName";
            this.textEditLastName.Size = new System.Drawing.Size(250, 20);
            this.textEditLastName.TabIndex = 2;

            // simpleButtonSave
            this.simpleButtonSave.Location = new System.Drawing.Point(20, 140);
            this.simpleButtonSave.Name = "simpleButtonSave";
            this.simpleButtonSave.Size = new System.Drawing.Size(100, 30);
            this.simpleButtonSave.TabIndex = 3;
            this.simpleButtonSave.Text = "Save";
            this.simpleButtonSave.Click += new System.EventHandler(this.simpleButtonSave_Click);

            // simpleButtonCancel
            this.simpleButtonCancel.Location = new System.Drawing.Point(170, 140);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(100, 30);
            this.simpleButtonCancel.TabIndex = 4;
            this.simpleButtonCancel.Text = "Cancel";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);

            // TenantFormUserControl
            this.Controls.Add(this.lookUpEditStaircase);
            this.Controls.Add(this.textEditFirstName);
            this.Controls.Add(this.textEditLastName);
            this.Controls.Add(this.simpleButtonSave);
            this.Controls.Add(this.simpleButtonCancel);
            this.Name = "TenantFormUserControl";
            this.Size = new System.Drawing.Size(300, 200);

            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStaircase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLastName.Properties)).EndInit();

            this.ResumeLayout(false);
        }

        #endregion
    }
}
