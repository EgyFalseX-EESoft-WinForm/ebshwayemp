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
    public partial class XRep_14 : DevExpress.XtraReports.UI.XtraReport
    {
        Datasource.dsLinq.dsLinqQryDataContext dsLinq = new Datasource.dsLinq.dsLinqQryDataContext();
        Datasource.dsQryTableAdapters.QueriesTableAdapter adpQry = new Datasource.dsQryTableAdapters.QueriesTableAdapter();
        Datasource.dsReportTableAdapters.XRep_14TableAdapter adp = new Datasource.dsReportTableAdapters.XRep_14TableAdapter();
        public XRep_14(int ID)
        {
            InitializeComponent();
            LoadHeader();
            adp.Fill(dsReport.XRep_14, ID);
            if (dsReport.XRep_14.Count == 0)
                return;
            Datasource.dsReport.XRep_14Row row = dsReport.XRep_14[0];

            lblGeha.Text = row.Gehawork;
            lblschool.Text = row.Gehawork;
            lblName.Text = row.EMPNAME;
            lblFrom.Text = row.EmpStatedate.ToShortDateString();
            lblTo.Text = row.agaza_end_date.ToShortDateString();
            lblTo2.Text = row.agaza_end_date.ToShortDateString();

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
