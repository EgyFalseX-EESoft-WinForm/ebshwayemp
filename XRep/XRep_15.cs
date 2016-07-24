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
    public partial class XRep_15 : DevExpress.XtraReports.UI.XtraReport
    {
        Datasource.dsLinq.dsLinqQryDataContext dsLinq = new Datasource.dsLinq.dsLinqQryDataContext();
        Datasource.dsQryTableAdapters.QueriesTableAdapter adpQry = new Datasource.dsQryTableAdapters.QueriesTableAdapter();
        Datasource.dsReportTableAdapters.XRep_15TableAdapter adp = new Datasource.dsReportTableAdapters.XRep_15TableAdapter();
        public XRep_15(int ID)
        {
            InitializeComponent();
            LoadHeader();
            adp.Fill(dsReport.XRep_15, ID);
            if (dsReport.XRep_15.Count == 0)
                return;
            Datasource.dsReport.XRep_15Row row = dsReport.XRep_15[0];

            lblGeha.Text = row.Gehawork;
            lblschool.Text = row.Gehawork;
            lblName.Text = row.EMPNAME;
            lblFrom.Text = row.EmpStatedate.ToShortDateString();
            lblTo.Text = row.agaza_end_date.ToShortDateString();

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

            if (data.logo != null)
                xrpbLogo.Image = Image.FromStream(new System.IO.MemoryStream(data.logo));
            
        }

    }
}
