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
    public partial class XRep_11 : DevExpress.XtraReports.UI.XtraReport
    {
        Datasource.dsLinq.dsLinqQryDataContext dsLinq = new Datasource.dsLinq.dsLinqQryDataContext();
        Datasource.dsQryTableAdapters.QueriesTableAdapter adpQry = new Datasource.dsQryTableAdapters.QueriesTableAdapter();
        Datasource.dsReportTableAdapters.XRep_07TableAdapter adp = new Datasource.dsReportTableAdapters.XRep_07TableAdapter();
        public XRep_11(int EmpId, DateTime From, DateTime To)
        {
            InitializeComponent();
            LoadHeader();
            adp.Fill(dsReport.XRep_07, EmpId);
            if (dsReport.XRep_07.Count == 0)
                return;
            Datasource.dsReport.XRep_07Row row = dsReport.XRep_07[0];

            lblName1.Text = row.EMPNAME;
            lblJob.Text = row.EmpJobName;
            lblGeha.Text = row.Gehawork;
            lblSchool.Text = row.Gehawork;
            lblFrom1.Text = From.ToShortDateString();
            lblFrom2.Text = From.ToShortDateString();
            lblTo.Text = To.ToShortDateString();
            lblName2.Text = row.EMPNAME;
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
