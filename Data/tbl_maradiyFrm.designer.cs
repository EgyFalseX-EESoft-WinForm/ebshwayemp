namespace Employee.Data
{
    partial class tbl_maradiyFrm
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
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.LSMSData = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmpID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colteldatae = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatefrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldateto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collagnatebea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatelagna = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkrar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.coldatein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMPNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGehaworktype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colEDARET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEDARET1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdaraMandopName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnkapaMandopName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnPrint1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnPrint2 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnPrint3 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.LSMSData;
            this.gridControlData.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlData.Location = new System.Drawing.Point(12, 38);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditDel,
            this.repositoryItemMemoExEdit1,
            this.repositoryItemButtonEditEdit});
            this.gridControlData.Size = new System.Drawing.Size(1031, 338);
            this.gridControlData.TabIndex = 0;
            this.gridControlData.UseEmbeddedNavigator = true;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            this.gridControlData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ActiveKeyDownEvent);
            // 
            // LSMSData
            // 
            this.LSMSData.ElementType = typeof(Employee.Datasource.dsLinq.vtbl_maradiy);
            this.LSMSData.KeyExpression = "mid";
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmpID,
            this.colteldatae,
            this.coldatefrom,
            this.coldateto,
            this.collagnatebea,
            this.coldatelagna,
            this.colkrar,
            this.coldatein,
            this.colUserName,
            this.colEMPNAME,
            this.colGehaworktype,
            this.gridColumn1,
            this.gridColumn3});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.NewItemRowText = "اضغط لاضافة جديد";
            this.gridViewData.OptionsBehavior.ReadOnly = true;
            this.gridViewData.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.ShowAutoFilterRow = true;
            this.gridViewData.OptionsView.ShowDetailButtons = false;
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
            // colteldatae
            // 
            this.colteldatae.AppearanceCell.Options.UseTextOptions = true;
            this.colteldatae.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colteldatae.AppearanceHeader.Options.UseTextOptions = true;
            this.colteldatae.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colteldatae.Caption = "تاريخ الابلاغ";
            this.colteldatae.FieldName = "teldatae";
            this.colteldatae.Name = "colteldatae";
            this.colteldatae.Visible = true;
            this.colteldatae.VisibleIndex = 3;
            // 
            // coldatefrom
            // 
            this.coldatefrom.AppearanceCell.Options.UseTextOptions = true;
            this.coldatefrom.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatefrom.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatefrom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatefrom.Caption = "من تاريخ";
            this.coldatefrom.FieldName = "datefrom";
            this.coldatefrom.Name = "coldatefrom";
            this.coldatefrom.Visible = true;
            this.coldatefrom.VisibleIndex = 6;
            // 
            // coldateto
            // 
            this.coldateto.AppearanceCell.Options.UseTextOptions = true;
            this.coldateto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldateto.AppearanceHeader.Options.UseTextOptions = true;
            this.coldateto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldateto.Caption = "الي تاريخ";
            this.coldateto.FieldName = "dateto";
            this.coldateto.Name = "coldateto";
            this.coldateto.Visible = true;
            this.coldateto.VisibleIndex = 7;
            // 
            // collagnatebea
            // 
            this.collagnatebea.AppearanceCell.Options.UseTextOptions = true;
            this.collagnatebea.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.collagnatebea.AppearanceHeader.Options.UseTextOptions = true;
            this.collagnatebea.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.collagnatebea.Caption = "اللجنة طبية";
            this.collagnatebea.FieldName = "lagnatebea";
            this.collagnatebea.Name = "collagnatebea";
            this.collagnatebea.Visible = true;
            this.collagnatebea.VisibleIndex = 4;
            // 
            // coldatelagna
            // 
            this.coldatelagna.AppearanceCell.Options.UseTextOptions = true;
            this.coldatelagna.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatelagna.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatelagna.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatelagna.Caption = "تاريخ اللجنة الطبية";
            this.coldatelagna.FieldName = "datelagna";
            this.coldatelagna.Name = "coldatelagna";
            this.coldatelagna.Visible = true;
            this.coldatelagna.VisibleIndex = 5;
            this.coldatelagna.Width = 101;
            // 
            // colkrar
            // 
            this.colkrar.AppearanceCell.Options.UseTextOptions = true;
            this.colkrar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colkrar.AppearanceHeader.Options.UseTextOptions = true;
            this.colkrar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colkrar.Caption = "قرار اللجنة";
            this.colkrar.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colkrar.FieldName = "krar";
            this.colkrar.Name = "colkrar";
            this.colkrar.Visible = true;
            this.colkrar.VisibleIndex = 8;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // coldatein
            // 
            this.coldatein.AppearanceCell.Options.UseTextOptions = true;
            this.coldatein.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatein.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatein.Caption = "تاريخ الادخال";
            this.coldatein.FieldName = "datein";
            this.coldatein.Name = "coldatein";
            // 
            // colUserName
            // 
            this.colUserName.AppearanceCell.Options.UseTextOptions = true;
            this.colUserName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserName.AppearanceHeader.Options.UseTextOptions = true;
            this.colUserName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserName.Caption = "مدخل البيان";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
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
            this.colGehaworktype.Caption = "جهة العمل";
            this.colGehaworktype.FieldName = "Gehaworktype";
            this.colGehaworktype.Name = "colGehaworktype";
            this.colGehaworktype.Visible = true;
            this.colGehaworktype.VisibleIndex = 2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "حذف";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEditDel;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 10;
            // 
            // repositoryItemButtonEditDel
            // 
            this.repositoryItemButtonEditDel.AutoHeight = false;
            this.repositoryItemButtonEditDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repositoryItemButtonEditDel.Name = "repositoryItemButtonEditDel";
            this.repositoryItemButtonEditDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditDel.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditDel_ButtonClick);
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "تعديل";
            this.gridColumn3.ColumnEdit = this.repositoryItemButtonEditEdit;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 9;
            // 
            // repositoryItemButtonEditEdit
            // 
            this.repositoryItemButtonEditEdit.AutoHeight = false;
            this.repositoryItemButtonEditEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEditEdit.Name = "repositoryItemButtonEditEdit";
            this.repositoryItemButtonEditEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditEdit_ButtonClick);
            // 
            // colEDARET
            // 
            this.colEDARET.AppearanceCell.Options.UseTextOptions = true;
            this.colEDARET.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEDARET.AppearanceHeader.Options.UseTextOptions = true;
            this.colEDARET.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEDARET.Caption = "اسم الاداره";
            this.colEDARET.FieldName = "EDARET";
            this.colEDARET.Name = "colEDARET";
            this.colEDARET.Visible = true;
            this.colEDARET.VisibleIndex = 0;
            // 
            // colEDARET1
            // 
            this.colEDARET1.AppearanceCell.Options.UseTextOptions = true;
            this.colEDARET1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEDARET1.AppearanceHeader.Options.UseTextOptions = true;
            this.colEDARET1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEDARET1.Caption = "الادارة";
            this.colEDARET1.FieldName = "EDARET";
            this.colEDARET1.Name = "colEDARET1";
            this.colEDARET1.Visible = true;
            this.colEDARET1.VisibleIndex = 0;
            // 
            // colEdaraMandopName
            // 
            this.colEdaraMandopName.AppearanceCell.Options.UseTextOptions = true;
            this.colEdaraMandopName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEdaraMandopName.AppearanceHeader.Options.UseTextOptions = true;
            this.colEdaraMandopName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEdaraMandopName.Caption = "الاسم";
            this.colEdaraMandopName.FieldName = "EdaraMandopName";
            this.colEdaraMandopName.Name = "colEdaraMandopName";
            this.colEdaraMandopName.Visible = true;
            this.colEdaraMandopName.VisibleIndex = 0;
            // 
            // colnkapaMandopName
            // 
            this.colnkapaMandopName.AppearanceCell.Options.UseTextOptions = true;
            this.colnkapaMandopName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnkapaMandopName.AppearanceHeader.Options.UseTextOptions = true;
            this.colnkapaMandopName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnkapaMandopName.Caption = "الاسم";
            this.colnkapaMandopName.FieldName = "nkapaMandopName";
            this.colnkapaMandopName.Name = "colnkapaMandopName";
            this.colnkapaMandopName.Visible = true;
            this.colnkapaMandopName.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "اسم الشهر";
            this.gridColumn2.FieldName = "MonthName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNew.Image = global::Employee.Properties.Resources.add_16x16;
            this.btnNew.Location = new System.Drawing.Point(961, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(82, 22);
            this.btnNew.StyleController = this.layoutControl1;
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "جديد";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnPrint3);
            this.layoutControl1.Controls.Add(this.btnPrint2);
            this.layoutControl1.Controls.Add(this.btnPrint1);
            this.layoutControl1.Controls.Add(this.btnNew);
            this.layoutControl1.Controls.Add(this.gridControlData);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(865, 190, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1055, 388);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnPrint1
            // 
            this.btnPrint1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPrint1.Image = global::Employee.Properties.Resources.Print;
            this.btnPrint1.Location = new System.Drawing.Point(12, 12);
            this.btnPrint1.Name = "btnPrint1";
            this.btnPrint1.Size = new System.Drawing.Size(77, 22);
            this.btnPrint1.StyleController = this.layoutControl1;
            this.btnPrint1.TabIndex = 0;
            this.btnPrint1.Text = "بلاغ وسية";
            this.btnPrint1.Click += new System.EventHandler(this.btnPrint1_Click);
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
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1055, 388);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlData;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1035, 342);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnNew;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(949, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(86, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(232, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(717, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnPrint1;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(81, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // btnPrint2
            // 
            this.btnPrint2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPrint2.Image = global::Employee.Properties.Resources.Print;
            this.btnPrint2.Location = new System.Drawing.Point(93, 12);
            this.btnPrint2.Name = "btnPrint2";
            this.btnPrint2.Size = new System.Drawing.Size(77, 22);
            this.btnPrint2.StyleController = this.layoutControl1;
            this.btnPrint2.TabIndex = 0;
            this.btnPrint2.Text = "مذكرة 1";
            this.btnPrint2.Click += new System.EventHandler(this.btnPrint2_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnPrint2;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(81, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(81, 26);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // btnPrint3
            // 
            this.btnPrint3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPrint3.Image = global::Employee.Properties.Resources.Print;
            this.btnPrint3.Location = new System.Drawing.Point(174, 12);
            this.btnPrint3.Name = "btnPrint3";
            this.btnPrint3.Size = new System.Drawing.Size(66, 22);
            this.btnPrint3.StyleController = this.layoutControl1;
            this.btnPrint3.TabIndex = 0;
            this.btnPrint3.Text = "مذكرة 2";
            this.btnPrint3.Click += new System.EventHandler(this.btnPrint3_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnPrint3;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(162, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(70, 26);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // tbl_maradiyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 388);
            this.Controls.Add(this.layoutControl1);
            this.Name = "tbl_maradiyFrm";
            this.Text = "الاجازات المرضية";
            this.Load += new System.EventHandler(this.FormFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSMSData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDel;
        private DevExpress.XtraGrid.Columns.GridColumn colEDARET;
        private DevExpress.XtraGrid.Columns.GridColumn colEDARET1;
        private DevExpress.XtraGrid.Columns.GridColumn colEdaraMandopName;
        private DevExpress.XtraGrid.Columns.GridColumn colnkapaMandopName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.Data.Linq.LinqServerModeSource LSMSData;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpID;
        private DevExpress.XtraGrid.Columns.GridColumn colteldatae;
        private DevExpress.XtraGrid.Columns.GridColumn coldatefrom;
        private DevExpress.XtraGrid.Columns.GridColumn coldateto;
        private DevExpress.XtraGrid.Columns.GridColumn collagnatebea;
        private DevExpress.XtraGrid.Columns.GridColumn coldatelagna;
        private DevExpress.XtraGrid.Columns.GridColumn colkrar;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn coldatein;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colEMPNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colGehaworktype;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditEdit;
        private DevExpress.XtraEditors.SimpleButton btnPrint1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnPrint2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnPrint3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}