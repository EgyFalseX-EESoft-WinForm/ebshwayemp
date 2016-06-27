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
    public partial class XRep_08 : DevExpress.XtraReports.UI.XtraReport
    {
        Datasource.dsLinq.dsLinqQryDataContext dsLinq = new Datasource.dsLinq.dsLinqQryDataContext();
        Datasource.dsQryTableAdapters.QueriesTableAdapter adpQry = new Datasource.dsQryTableAdapters.QueriesTableAdapter();
        Datasource.dsReportTableAdapters.XRep_08TableAdapter adp = new Datasource.dsReportTableAdapters.XRep_08TableAdapter();
        public XRep_08(int ID)
        {
            InitializeComponent();
            LoadHeader();
            adp.Fill(dsReport.XRep_08, ID);
            if (dsReport.XRep_08.Count == 0)
                return;
            Datasource.dsReport.XRep_08Row row = dsReport.XRep_08[0];

            lblGeha.Text = row.Gehawork;
            lblName.Text = row.EMPNAME;
            lblJob.Text = row.EmpJobName;
            lblCountry.Text = row.Gehawork_New;
            lblNumber.Text = row.design.ToString();
            lblDate.Text = row.EmpStatedate.ToShortDateString();

            lblToday.Text = adpQry.GetServerDatetime().Value.ToShortDateString();
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
