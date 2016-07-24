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
    public partial class XRep_13 : DevExpress.XtraReports.UI.XtraReport
    {
        Datasource.dsLinq.dsLinqQryDataContext dsLinq = new Datasource.dsLinq.dsLinqQryDataContext();
        Datasource.dsQryTableAdapters.QueriesTableAdapter adpQry = new Datasource.dsQryTableAdapters.QueriesTableAdapter();
        Datasource.dsReportTableAdapters.XRep_13TableAdapter adp = new Datasource.dsReportTableAdapters.XRep_13TableAdapter();
        public XRep_13(int ID)
        {
            InitializeComponent();
            LoadHeader();
            adp.Fill(dsReport.XRep_13, ID);
            if (dsReport.XRep_13.Count == 0)
                return;
            Datasource.dsReport.XRep_13Row row = dsReport.XRep_13[0];
            if (!row.IsNull("design"))
                lblNumber.Text = row.design.ToString();
            lbltoDate.Text = adpQry.GetServerDatetime().Value.ToShortDateString();
            lblName.Text = row.EMPNAME;
            lblDate.Text = row.EmpStatedate.ToShortDateString();

            lbltoDate2.Text = adpQry.GetServerDatetime().Value.ToShortDateString();
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
