namespace Employee.XRep
{
    partial class XRep_12_Frm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lueGeha = new DevExpress.XtraEditors.LookUpEdit();
            this.LSMSGeha = new DevExpress.Data.Linq.LinqServerModeSource();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.xRep12ABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReport = new Employee.Datasource.dsReport();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmpID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMPNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBIRTH_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodemortabat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGehaworktype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpJobName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colqualName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSpecializationName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQualifiedPlaceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xRep_12_ATableAdapter = new Employee.Datasource.dsReportTableAdapters.XRep_12_ATableAdapter();
            this.colSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueGeha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSGeha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xRep12ABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lueGeha);
            this.layoutControl1.Controls.Add(this.btnPrint);
            this.layoutControl1.Controls.Add(this.gridControlMain);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(534, 160, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(730, 358);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lueGeha
            // 
            this.lueGeha.Location = new System.Drawing.Point(12, 12);
            this.lueGeha.Name = "lueGeha";
            this.lueGeha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueGeha.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Gehawork", "الاسم", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lueGeha.Properties.DataSource = this.LSMSGeha;
            this.lueGeha.Properties.DisplayMember = "Gehawork";
            this.lueGeha.Properties.NullText = "";
            this.lueGeha.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueGeha.Properties.ValueMember = "GehaworkId";
            this.lueGeha.Size = new System.Drawing.Size(199, 20);
            this.lueGeha.StyleController = this.layoutControl1;
            this.lueGeha.TabIndex = 6;
            this.lueGeha.EditValueChanged += new System.EventHandler(this.lueGeha_EditValueChanged);
            // 
            // LSMSGeha
            // 
            this.LSMSGeha.ElementType = typeof(Employee.Datasource.dsLinq.TBLGehawork);
            this.LSMSGeha.KeyExpression = "[GehaworkId]";
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::Employee.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(215, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(78, 22);
            this.btnPrint.StyleController = this.layoutControl1;
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // gridControlMain
            // 
            this.gridControlMain.DataSource = this.xRep12ABindingSource;
            this.gridControlMain.Location = new System.Drawing.Point(12, 38);
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.Size = new System.Drawing.Size(706, 308);
            this.gridControlMain.TabIndex = 4;
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // xRep12ABindingSource
            // 
            this.xRep12ABindingSource.DataMember = "XRep_12_A";
            this.xRep12ABindingSource.DataSource = this.dsReport;
            // 
            // dsReport
            // 
            this.dsReport.DataSetName = "dsReport";
            this.dsReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSelected,
            this.colEmpID,
            this.colEMPNAME,
            this.colBIRTH_DATE,
            this.colcodemortabat,
            this.colGehaworktype,
            this.colEmpJobName,
            this.colqualName,
            this.colSpecializationName,
            this.colQualifiedPlaceName});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewMain.OptionsView.ShowFooter = true;
            this.gridViewMain.OptionsView.ShowGroupPanel = false;
            this.gridViewMain.OptionsView.ShowIndicator = false;
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
            this.colEmpID.VisibleIndex = 1;
            this.colEmpID.Width = 128;
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
            this.colEMPNAME.VisibleIndex = 2;
            this.colEMPNAME.Width = 539;
            // 
            // colBIRTH_DATE
            // 
            this.colBIRTH_DATE.AppearanceCell.Options.UseTextOptions = true;
            this.colBIRTH_DATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBIRTH_DATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colBIRTH_DATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBIRTH_DATE.Caption = "تاريخ الميلاد";
            this.colBIRTH_DATE.FieldName = "BIRTH_DATE";
            this.colBIRTH_DATE.Name = "colBIRTH_DATE";
            this.colBIRTH_DATE.Visible = true;
            this.colBIRTH_DATE.VisibleIndex = 3;
            this.colBIRTH_DATE.Width = 539;
            // 
            // colcodemortabat
            // 
            this.colcodemortabat.AppearanceCell.Options.UseTextOptions = true;
            this.colcodemortabat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcodemortabat.AppearanceHeader.Options.UseTextOptions = true;
            this.colcodemortabat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcodemortabat.Caption = "مرتبات";
            this.colcodemortabat.FieldName = "codemortabat";
            this.colcodemortabat.Name = "colcodemortabat";
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
            // 
            // colEmpJobName
            // 
            this.colEmpJobName.AppearanceCell.Options.UseTextOptions = true;
            this.colEmpJobName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpJobName.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmpJobName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpJobName.Caption = "الوظيفة";
            this.colEmpJobName.FieldName = "EmpJobName";
            this.colEmpJobName.Name = "colEmpJobName";
            this.colEmpJobName.Visible = true;
            this.colEmpJobName.VisibleIndex = 4;
            this.colEmpJobName.Width = 544;
            // 
            // colqualName
            // 
            this.colqualName.AppearanceCell.Options.UseTextOptions = true;
            this.colqualName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colqualName.AppearanceHeader.Options.UseTextOptions = true;
            this.colqualName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colqualName.Caption = "المؤهل";
            this.colqualName.FieldName = "qualName";
            this.colqualName.Name = "colqualName";
            // 
            // colSpecializationName
            // 
            this.colSpecializationName.AppearanceCell.Options.UseTextOptions = true;
            this.colSpecializationName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSpecializationName.AppearanceHeader.Options.UseTextOptions = true;
            this.colSpecializationName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSpecializationName.Caption = "التخصص";
            this.colSpecializationName.FieldName = "SpecializationName";
            this.colSpecializationName.Name = "colSpecializationName";
            // 
            // colQualifiedPlaceName
            // 
            this.colQualifiedPlaceName.AppearanceCell.Options.UseTextOptions = true;
            this.colQualifiedPlaceName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQualifiedPlaceName.AppearanceHeader.Options.UseTextOptions = true;
            this.colQualifiedPlaceName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQualifiedPlaceName.Caption = "مكان التخرج";
            this.colQualifiedPlaceName.FieldName = "QualifiedPlaceName";
            this.colQualifiedPlaceName.Name = "colQualifiedPlaceName";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(730, 358);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlMain;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(710, 312);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnPrint;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(203, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(82, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(285, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(425, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lueGeha;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(203, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // xRep_12_ATableAdapter
            // 
            this.xRep_12_ATableAdapter.ClearBeforeFill = true;
            // 
            // colSelected
            // 
            this.colSelected.AppearanceCell.Options.UseTextOptions = true;
            this.colSelected.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSelected.AppearanceHeader.Options.UseTextOptions = true;
            this.colSelected.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSelected.Caption = "اختر";
            this.colSelected.FieldName = "Selected";
            this.colSelected.Name = "colSelected";
            this.colSelected.Visible = true;
            this.colSelected.VisibleIndex = 0;
            // 
            // XRep_12_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 358);
            this.Controls.Add(this.layoutControl1);
            this.Name = "XRep_12_Frm";
            this.Text = "طلب تدرج مرتبات";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueGeha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSGeha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xRep12ABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.LookUpEdit lueGeha;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSGeha;
        private System.Windows.Forms.BindingSource xRep12ABindingSource;
        private Datasource.dsReport dsReport;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpID;
        private DevExpress.XtraGrid.Columns.GridColumn colEMPNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colBIRTH_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colcodemortabat;
        private DevExpress.XtraGrid.Columns.GridColumn colGehaworktype;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpJobName;
        private DevExpress.XtraGrid.Columns.GridColumn colqualName;
        private DevExpress.XtraGrid.Columns.GridColumn colSpecializationName;
        private DevExpress.XtraGrid.Columns.GridColumn colQualifiedPlaceName;
        private Datasource.dsReportTableAdapters.XRep_12_ATableAdapter xRep_12_ATableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colSelected;
    }
}