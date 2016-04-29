namespace Employee.Data
{
    partial class tbl_maradiyEditFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tbl_maradiyEditFrm));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.tbkrar = new DevExpress.XtraEditors.MemoEdit();
            this.dedatelagna = new DevExpress.XtraEditors.DateEdit();
            this.tblagnatebea = new DevExpress.XtraEditors.TextEdit();
            this.dedatefrom = new DevExpress.XtraEditors.DateEdit();
            this.dedateto = new DevExpress.XtraEditors.DateEdit();
            this.deteldatae = new DevExpress.XtraEditors.DateEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lueEmpID = new DevExpress.XtraEditors.LookUpEdit();
            this.tblmaradiyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsData = new Employee.Datasource.dsData();
            this.LSMSEmp = new DevExpress.Data.Linq.LinqServerModeSource();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmpID = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxvp = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.tbl_maradiyTableAdapter = new Employee.Datasource.dsDataTableAdapters.tbl_maradiyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbkrar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedatelagna.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedatelagna.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblagnatebea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedatefrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedatefrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedateto.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedateto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deteldatae.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deteldatae.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmaradiyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.tbkrar);
            this.dataLayoutControl1.Controls.Add(this.dedatelagna);
            this.dataLayoutControl1.Controls.Add(this.tblagnatebea);
            this.dataLayoutControl1.Controls.Add(this.dedatefrom);
            this.dataLayoutControl1.Controls.Add(this.dedateto);
            this.dataLayoutControl1.Controls.Add(this.deteldatae);
            this.dataLayoutControl1.Controls.Add(this.btnCancel);
            this.dataLayoutControl1.Controls.Add(this.btnSave);
            this.dataLayoutControl1.Controls.Add(this.lueEmpID);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(931, 197, 350, 632);
            this.dataLayoutControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(495, 221);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // tbkrar
            // 
            this.tbkrar.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tblmaradiyBindingSource, "krar", true));
            this.tbkrar.Location = new System.Drawing.Point(12, 132);
            this.tbkrar.Name = "tbkrar";
            this.tbkrar.Size = new System.Drawing.Size(386, 51);
            this.tbkrar.StyleController = this.dataLayoutControl1;
            this.tbkrar.TabIndex = 36;
            // 
            // dedatelagna
            // 
            this.dedatelagna.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tblmaradiyBindingSource, "datelagna", true));
            this.dedatelagna.EditValue = null;
            this.dedatelagna.Location = new System.Drawing.Point(12, 108);
            this.dedatelagna.Name = "dedatelagna";
            this.dedatelagna.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedatelagna.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedatelagna.Size = new System.Drawing.Size(386, 20);
            this.dedatelagna.StyleController = this.dataLayoutControl1;
            this.dedatelagna.TabIndex = 35;
            // 
            // tblagnatebea
            // 
            this.tblagnatebea.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tblmaradiyBindingSource, "lagnatebea", true));
            this.tblagnatebea.Location = new System.Drawing.Point(12, 84);
            this.tblagnatebea.Name = "tblagnatebea";
            this.tblagnatebea.Size = new System.Drawing.Size(386, 20);
            this.tblagnatebea.StyleController = this.dataLayoutControl1;
            this.tblagnatebea.TabIndex = 34;
            // 
            // dedatefrom
            // 
            this.dedatefrom.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tblmaradiyBindingSource, "datefrom", true));
            this.dedatefrom.EditValue = null;
            this.dedatefrom.Location = new System.Drawing.Point(249, 60);
            this.dedatefrom.Name = "dedatefrom";
            this.dedatefrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedatefrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedatefrom.Size = new System.Drawing.Size(149, 20);
            this.dedatefrom.StyleController = this.dataLayoutControl1;
            this.dedatefrom.TabIndex = 33;
            // 
            // dedateto
            // 
            this.dedateto.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tblmaradiyBindingSource, "dateto", true));
            this.dedateto.EditValue = null;
            this.dedateto.Location = new System.Drawing.Point(12, 60);
            this.dedateto.Name = "dedateto";
            this.dedateto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dedateto.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dedateto.Size = new System.Drawing.Size(148, 20);
            this.dedateto.StyleController = this.dataLayoutControl1;
            this.dedateto.TabIndex = 32;
            // 
            // deteldatae
            // 
            this.deteldatae.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tblmaradiyBindingSource, "teldatae", true));
            this.deteldatae.EditValue = null;
            this.deteldatae.Location = new System.Drawing.Point(12, 36);
            this.deteldatae.Name = "deteldatae";
            this.deteldatae.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deteldatae.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deteldatae.Size = new System.Drawing.Size(386, 20);
            this.deteldatae.StyleController = this.dataLayoutControl1;
            this.deteldatae.TabIndex = 31;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::Employee.Properties.Resources.Close;
            this.btnCancel.Location = new System.Drawing.Point(378, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 22);
            this.btnCancel.StyleController = this.dataLayoutControl1;
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "الغاء";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Employee.Properties.Resources.apply_16x16;
            this.btnSave.Location = new System.Drawing.Point(12, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(362, 22);
            this.btnSave.StyleController = this.dataLayoutControl1;
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lueEmpID
            // 
            this.lueEmpID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tblmaradiyBindingSource, "EmpID", true));
            this.lueEmpID.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lueEmpID.EnterMoveNextControl = true;
            this.lueEmpID.Location = new System.Drawing.Point(12, 12);
            this.lueEmpID.Name = "lueEmpID";
            this.lueEmpID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEmpID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpID", "كود"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EMPNAME", "اسم")});
            this.lueEmpID.Properties.DataSource = this.LSMSEmp;
            this.lueEmpID.Properties.DisplayMember = "EMPNAME";
            this.lueEmpID.Properties.NullText = "";
            this.lueEmpID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueEmpID.Properties.ValueMember = "EmpID";
            this.lueEmpID.Size = new System.Drawing.Size(386, 20);
            this.lueEmpID.StyleController = this.dataLayoutControl1;
            this.lueEmpID.TabIndex = 2;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxvp.SetValidationRule(this.lueEmpID, conditionValidationRule1);
            // 
            // tblmaradiyBindingSource
            // 
            this.tblmaradiyBindingSource.DataMember = "tbl_maradiy";
            this.tblmaradiyBindingSource.DataSource = this.dsData;
            // 
            // dsData
            // 
            this.dsData.DataSetName = "dsData";
            this.dsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LSMSEmp
            // 
            this.LSMSEmp.ElementType = typeof(Employee.Datasource.dsLinq.vTBL_Emp);
            this.LSMSEmp.KeyExpression = "[EmpID]";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.ItemForEmpID,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(495, 221);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnSave;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 175);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(366, 26);
            this.layoutControlItem1.Text = "Save";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnCancel;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(366, 175);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(109, 26);
            this.layoutControlItem2.Text = "Cancel";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // ItemForEmpID
            // 
            this.ItemForEmpID.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForEmpID.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForEmpID.Control = this.lueEmpID;
            this.ItemForEmpID.CustomizationFormText = "Emp ID";
            this.ItemForEmpID.Location = new System.Drawing.Point(0, 0);
            this.ItemForEmpID.Name = "ItemForEmpID";
            this.ItemForEmpID.Size = new System.Drawing.Size(475, 24);
            this.ItemForEmpID.Text = "الاسم";
            this.ItemForEmpID.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForEmpID.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItem3.Control = this.deteldatae;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(475, 24);
            this.layoutControlItem3.Text = "تاريخ الابلاغ";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem4.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItem4.Control = this.dedateto;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(237, 24);
            this.layoutControlItem4.Text = "الي تاريخ";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem5.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItem5.Control = this.dedatefrom;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(237, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(238, 24);
            this.layoutControlItem5.Text = "من تاريخ";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem6.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItem6.Control = this.tblagnatebea;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(475, 24);
            this.layoutControlItem6.Text = "اللجنة الطبية";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem7.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem7.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItem7.Control = this.dedatelagna;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(475, 24);
            this.layoutControlItem7.Text = "تاريخ اللجنة الطبية";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem8.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem8.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItem8.Control = this.tbkrar;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(475, 55);
            this.layoutControlItem8.Text = "قرار اللجنة";
            this.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(82, 13);
            // 
            // tbl_maradiyTableAdapter
            // 
            this.tbl_maradiyTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_maradiyEditFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(495, 221);
            this.Controls.Add(this.dataLayoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tbl_maradiyEditFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "محرر";
            this.Load += new System.EventHandler(this.tblmortabatAddFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbkrar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedatelagna.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedatelagna.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblagnatebea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedatefrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedatefrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedateto.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dedateto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deteldatae.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deteldatae.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmpID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmaradiyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmpID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.LookUpEdit lueEmpID;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxvp;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSEmp;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmpID;
        private DevExpress.XtraEditors.DateEdit deteldatae;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.DateEdit dedatefrom;
        private DevExpress.XtraEditors.DateEdit dedateto;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.MemoEdit tbkrar;
        private DevExpress.XtraEditors.DateEdit dedatelagna;
        private DevExpress.XtraEditors.TextEdit tblagnatebea;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private Datasource.dsData dsData;
        private System.Windows.Forms.BindingSource tblmaradiyBindingSource;
        private Datasource.dsDataTableAdapters.tbl_maradiyTableAdapter tbl_maradiyTableAdapter;
    }
}