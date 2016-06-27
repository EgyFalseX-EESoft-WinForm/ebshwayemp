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
    public partial class XRep_06 : DevExpress.XtraReports.UI.XtraReport
    {
        Datasource.dsLinq.dsLinqQryDataContext dsLinq = new Datasource.dsLinq.dsLinqQryDataContext();
        Datasource.dsQryTableAdapters.QueriesTableAdapter adpQry = new Datasource.dsQryTableAdapters.QueriesTableAdapter();
        Datasource.dsReportTableAdapters.XRep_05TableAdapter adp = new Datasource.dsReportTableAdapters.XRep_05TableAdapter();
        public XRep_06(int EmpId, DateTime From, DateTime To)
        {
            InitializeComponent();
            LoadHeader();
            adp.Fill(dsReport.XRep_05, EmpId);
            if (dsReport.XRep_05.Count == 0)
                return;
            Datasource.dsReport.XRep_05Row row = dsReport.XRep_05[0];

            lblSchool.Text = row.Gehawork;
            lblDate.Text = adpQry.GetServerDatetime().Value.ToShortDateString();
            lblName.Text = row.EMPNAME;
            lblJob.Text = row.EmpJobName;
            lblFrom.Text = From.ToShortDateString();
            lblTo.Text = To.ToShortDateString();
            lblPeriod.Text = To.Subtract(From).TotalDays.ToString();
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
