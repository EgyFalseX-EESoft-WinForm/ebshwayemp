using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraEditors;
using System.Linq;

namespace Employee.XRep
{
    public partial class XRep_05 : DevExpress.XtraReports.UI.XtraReport
    {
        Datasource.dsLinq.dsLinqQryDataContext dsLinq = new Datasource.dsLinq.dsLinqQryDataContext();
        Datasource.dsQryTableAdapters.QueriesTableAdapter adpQry = new Datasource.dsQryTableAdapters.QueriesTableAdapter();
        public XRep_05()
        {
            InitializeComponent();
            LoadHeader();
        }
        private void LoadHeader()
        {
            Datasource.dsReportTableAdapters.tblorgprogTableAdapter adp = new Datasource.dsReportTableAdapters.tblorgprogTableAdapter();
            adp.Fill(dsReport.tblorgprog);
            if (dsReport.tblorgprog.Count == 0)
                return;
            Datasource.dsReport.tblorgprogRow data = dsReport.tblorgprog[0];
            lblH1.Text = data.hederright1;
            lblH2.Text = data.hederright2;
            lblH3.Text = data.hederright3;

            lblF1.Text = data.foter1;
            lblF2.Text = data.foter2;
            lblF3.Text = data.foter3;

            if (data.logo != null)
                xrpbLogo.Image = Image.FromStream(new System.IO.MemoryStream(data.logo));
            
        }
        private GridLookUpEdit GeneratParamEmp()
        {
            DevExpress.XtraEditors.GridLookUpEdit lue = new GridLookUpEdit();
            DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            DevExpress.Data.Linq.LinqServerModeSource LSMSEmp = new DevExpress.Data.Linq.LinqServerModeSource();
            DevExpress.XtraGrid.Columns.GridColumn colEmpID = new DevExpress.XtraGrid.Columns.GridColumn();
            DevExpress.XtraGrid.Columns.GridColumn colEMPNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            DevExpress.XtraGrid.Columns.GridColumn colGehaworktype = new DevExpress.XtraGrid.Columns.GridColumn();
            DevExpress.XtraGrid.Columns.GridColumn coleschoolcode = new DevExpress.XtraGrid.Columns.GridColumn();

            ((System.ComponentModel.ISupportInitialize)(lue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(LSMSEmp)).BeginInit();
            SuspendLayout();

            // 
            // LSMSEmp
            // 
            LSMSEmp.ElementType = typeof(Employee.Datasource.dsLinq.vTBL_Emp);
            LSMSEmp.KeyExpression = "[EmpID]";
            // 
            // colEmpID
            // 
            colEmpID.AppearanceCell.Options.UseTextOptions = true;
            colEmpID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colEmpID.AppearanceHeader.Options.UseTextOptions = true;
            colEmpID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colEmpID.Caption = "كود";
            colEmpID.FieldName = "EmpID";
            colEmpID.Name = "colEmpID";
            colEmpID.Visible = true;
            colEmpID.VisibleIndex = 0;
            // 
            // colEMPNAME
            // 
            colEMPNAME.AppearanceCell.Options.UseTextOptions = true;
            colEMPNAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colEMPNAME.AppearanceHeader.Options.UseTextOptions = true;
            colEMPNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colEMPNAME.Caption = "الاسم";
            colEMPNAME.FieldName = "EMPNAME";
            colEMPNAME.Name = "colEMPNAME";
            colEMPNAME.Visible = true;
            colEMPNAME.VisibleIndex = 1;
            // 
            // colGehaworktype
            // 
            colGehaworktype.AppearanceCell.Options.UseTextOptions = true;
            colGehaworktype.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colGehaworktype.AppearanceHeader.Options.UseTextOptions = true;
            colGehaworktype.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colGehaworktype.Caption = "الجهة";
            colGehaworktype.FieldName = "Gehaworktype";
            colGehaworktype.Name = "colGehaworktype";
            colGehaworktype.Visible = true;
            colGehaworktype.VisibleIndex = 2;
            // 
            // coleschoolcode
            // 
            coleschoolcode.AppearanceCell.Options.UseTextOptions = true;
            coleschoolcode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            coleschoolcode.AppearanceHeader.Options.UseTextOptions = true;
            coleschoolcode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            coleschoolcode.Caption = "كود المدرسة";
            coleschoolcode.FieldName = "eschoolcode";
            coleschoolcode.Name = "coleschoolcode";
            coleschoolcode.Visible = true;
            coleschoolcode.VisibleIndex = 3;
            // 
            // gridLookUpEdit1View
            // 
            gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            colEmpID,
            colEMPNAME,
            colGehaworktype,
            coleschoolcode});
            gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // lue
            // 
            lue.EditValue = null;
            lue.Name = "lue";
            lue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            lue.Properties.DataSource = LSMSEmp;
            lue.Properties.DisplayMember = "EMPNAME";
            lue.Properties.NullText = "";
            lue.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            lue.Properties.ValueMember = "EmpID";
            lue.Properties.View = gridLookUpEdit1View;
            lue.Size = new System.Drawing.Size(178, 20);
            lue.TabIndex = 0;

            ((System.ComponentModel.ISupportInitialize)(gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(LSMSEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lue.Properties)).EndInit();
            

            LSMSEmp.QueryableSource = from q in new Datasource.dsLinq.dsLinqQryDataContext().vTBL_Emps select q;
            
            return lue;
        }
        private void XRep_ParametersRequestBeforeShow(object sender, ParametersRequestEventArgs e)
        {
            foreach (ParameterInfo info in e.ParametersInformation)
            {
                if (info.Parameter.Name == "paramEmpID")
                {
                    info.Editor = GeneratParamEmp();
                  
                    info.Parameter.Value = DBNull.Value;
                    continue;
                }
            }
        }
        private void XRep_ParametersRequestSubmit(object sender, ParametersRequestEventArgs e)
        {
            if (e.ParametersInformation[0].Parameter.Value == null)
                return;
            GridLookUpEdit lue = (GridLookUpEdit)(e.ParametersInformation[0].Editor);
            Datasource.dsLinq.vTBL_Emp emp = (Datasource.dsLinq.vTBL_Emp)lue.GetSelectedDataRow();
            if (emp == null)
                return;

            txtEMPNAME.Text = emp.EMPNAME;
            lblEmpNationalID.Text = emp.EmpNationalID;
            lblBIRTH_DATE.Text = emp.BIRTH_DATE.ToShortDateString();
            lblEmpJobName.Text = emp.EmpJobName;
            lblqualName.Text = emp.qualName;
            lblSpecializationName.Text = emp.SpecializationName;
            lblMoaahel_Date.Text = emp.Moaahel_Date;
            lblQualifiedPlaceName.Text = emp.QualifiedPlaceName;
            lblWork_Start_Date.Text = emp.Work_Start_Date.ToShortDateString();
            if (emp.End_Work_Date != null)
                lblEnd_Work_Date.Text = ((DateTime)emp.End_Work_Date).ToShortDateString();
            
            lblGetDate.Text = ((DateTime)new Datasource.dsQryTableAdapters.QueriesTableAdapter().GetServerDatetime()).ToShortDateString();
            lbltameen_no.Text = emp.tameen_no;
            lbltbetaka_tameen.Text = emp.betaka_tameen;

        }

    }
}
