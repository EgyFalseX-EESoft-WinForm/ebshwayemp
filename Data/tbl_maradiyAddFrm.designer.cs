namespace Employee.Data
{
    partial class tbl_maradiyAddFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tbl_maradiyAddFrm));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.LSMSEmp = new DevExpress.Data.Linq.LinqServerModeSource();
            this.deteldatae = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemFormonth_code = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmpID = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxvp = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.lueEmpID = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmpID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMPNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGehaworktype = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deteldatae.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deteldatae.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFormonth_code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.btnCancel);
            this.dataLayoutControl1.Controls.Add(this.btnSave);
            this.dataLayoutControl1.Controls.Add(this.deteldatae);
            this.dataLayoutControl1.Controls.Add(this.lueEmpID);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(691, 209, 250, 632);
            this.dataLayoutControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(431, 96);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::Employee.Properties.Resources.Close;
            this.btnCancel.Location = new System.Drawing.Point(329, 60);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 22);
            this.btnCancel.StyleController = this.dataLayoutControl1;
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "الغاء";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Employee.Properties.Resources.apply_16x16;
            this.btnSave.Location = new System.Drawing.Point(12, 60);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(313, 22);
            this.btnSave.StyleController = this.dataLayoutControl1;
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // LSMSEmp
            // 
            this.LSMSEmp.ElementType = typeof(Employee.Datasource.dsLinq.vTBL_Emp);
            this.LSMSEmp.KeyExpression = "[EmpID]";
            // 
            // deteldatae
            // 
            this.deteldatae.EditValue = null;
            this.deteldatae.Location = new System.Drawing.Point(12, 36);
            this.deteldatae.Name = "deteldatae";
            this.deteldatae.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deteldatae.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.deteldatae.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deteldatae.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.deteldatae.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deteldatae.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.deteldatae.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deteldatae.Size = new System.Drawing.Size(352, 20);
            this.deteldatae.StyleController = this.dataLayoutControl1;
            this.deteldatae.TabIndex = 6;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxvp.SetValidationRule(this.deteldatae, conditionValidationRule1);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.ItemFormonth_code,
            this.ItemForEmpID});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(431, 96);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnSave;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(317, 28);
            this.layoutControlItem1.Text = "Save";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnCancel;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(317, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(94, 28);
            this.layoutControlItem2.Text = "Cancel";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // ItemFormonth_code
            // 
            this.ItemFormonth_code.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemFormonth_code.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemFormonth_code.Control = this.deteldatae;
            this.ItemFormonth_code.CustomizationFormText = "month_code";
            this.ItemFormonth_code.Location = new System.Drawing.Point(0, 24);
            this.ItemFormonth_code.Name = "ItemFormonth_code";
            this.ItemFormonth_code.Size = new System.Drawing.Size(411, 24);
            this.ItemFormonth_code.Text = "تاريخ الابلاغ";
            this.ItemFormonth_code.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemFormonth_code.TextSize = new System.Drawing.Size(52, 13);
            // 
            // ItemForEmpID
            // 
            this.ItemForEmpID.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForEmpID.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForEmpID.Control = this.lueEmpID;
            this.ItemForEmpID.CustomizationFormText = "Emp ID";
            this.ItemForEmpID.Location = new System.Drawing.Point(0, 0);
            this.ItemForEmpID.Name = "ItemForEmpID";
            this.ItemForEmpID.Size = new System.Drawing.Size(411, 24);
            this.ItemForEmpID.Text = "الاسم";
            this.ItemForEmpID.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForEmpID.TextSize = new System.Drawing.Size(52, 13);
            // 
            // lueEmpID
            // 
            this.lueEmpID.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lueEmpID.Location = new System.Drawing.Point(12, 12);
            this.lueEmpID.Name = "lueEmpID";
            this.lueEmpID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEmpID.Properties.DataSource = this.LSMSEmp;
            this.lueEmpID.Properties.DisplayMember = "EMPNAME";
            this.lueEmpID.Properties.NullText = "";
            this.lueEmpID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueEmpID.Properties.ValueMember = "EmpID";
            this.lueEmpID.Properties.View = this.gridLookUpEdit1View;
            this.lueEmpID.Size = new System.Drawing.Size(352, 20);
            this.lueEmpID.StyleController = this.dataLayoutControl1;
            this.lueEmpID.TabIndex = 7;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmpID,
            this.colEMPNAME,
            this.colGehaworktype});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colEmpID
            // 
            this.colEmpID.AppearanceCell.Options.UseTextOptions = true;
            this.colEmpID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpID.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmpID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpID.Caption = "كود";
            this.colEmpID.FieldName = "EmpID";
            this.colEmpID.Name = "colEmpID";
            this.colEmpID.Visible = true;
            this.colEmpID.VisibleIndex = 0;
            // 
            // colEMPNAME
            // 
            this.colEMPNAME.AppearanceCell.Options.UseTextOptions = true;
            this.colEMPNAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEMPNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colEMPNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEMPNAME.Caption = "الاسم";
            this.colEMPNAME.FieldName = "EMPNAME";
            this.colEMPNAME.Name = "colEMPNAME";
            this.colEMPNAME.Visible = true;
            this.colEMPNAME.VisibleIndex = 1;
            // 
            // colGehaworktype
            // 
            this.colGehaworktype.AppearanceCell.Options.UseTextOptions = true;
            this.colGehaworktype.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGehaworktype.AppearanceHeader.Options.UseTextOptions = true;
            this.colGehaworktype.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGehaworktype.Caption = "الجهة";
            this.colGehaworktype.FieldName = "Gehaworktype";
            this.colGehaworktype.Name = "colGehaworktype";
            this.colGehaworktype.Visible = true;
            this.colGehaworktype.VisibleIndex = 2;
            // 
            // tbl_maradiyAddFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(431, 96);
            this.Controls.Add(this.dataLayoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tbl_maradiyAddFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "محرر";
            this.Load += new System.EventHandler(this.tblmortabatAddFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LSMSEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deteldatae.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deteldatae.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFormonth_code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxvp;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSEmp;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmpID;
        private DevExpress.XtraLayout.LayoutControlItem ItemFormonth_code;
        private DevExpress.XtraEditors.DateEdit deteldatae;
        private DevExpress.XtraEditors.GridLookUpEdit lueEmpID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpID;
        private DevExpress.XtraGrid.Columns.GridColumn colEMPNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colGehaworktype;
    }
}