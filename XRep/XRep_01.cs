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
    public partial class XRep_01 : DevExpress.XtraReports.UI.XtraReport
    {
        //Datasource.dsReportTableAdapters.AppOptionsTableAdapter adpOptions = new Datasource.dsReportTableAdapters.AppOptionsTableAdapter();
        //Datasource.dsReportTableAdapters.XRep_01ATableAdapter adp_A = new Datasource.dsReportTableAdapters.XRep_01ATableAdapter();
        //Datasource.dsReportTableAdapters.XRep_01BTableAdapter adp_B = new Datasource.dsReportTableAdapters.XRep_01BTableAdapter();
        Datasource.dsLinq.dsLinqQryDataContext dsLinq = new Datasource.dsLinq.dsLinqQryDataContext();
        Datasource.dsQryTableAdapters.QueriesTableAdapter adpQry = new Datasource.dsQryTableAdapters.QueriesTableAdapter();
        public XRep_01(int EmpID, DateTime teldatae)
        {
            InitializeComponent();
            LoadHeader();
            LoadData(EmpID, teldatae);
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
        private void LoadData(int EmpID, DateTime teldatae)
        {
            Datasource.dsLinq.vTBL_Emp emp = (from q in dsLinq.vTBL_Emps where q.EmpID == EmpID select q).ToArray<Datasource.dsLinq.vTBL_Emp>()[0];
            lblEMPNAME.Text = emp.EMPNAME;
            lblJob.Text = emp.Gehaworktype;
            lblNOW.Text = ((DateTime)adpQry.GetServerDatetime()).ToShortDateString();
            lblteldatae.Text = teldatae.ToShortDateString();

            //adpOptions.Fill(dsReport.AppOptions);
            //xrpbLogo.Image = Image.FromStream(new System.IO.MemoryStream(dsReport.AppOptions[0].SchoolLogo));

            //adp_A.Fill(dsReport.XRep_01A);
            //adp_B.Fill(dsReport.XRep_01B);

        }
        
    }
}
