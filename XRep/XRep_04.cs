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
    public partial class XRep_04 : DevExpress.XtraReports.UI.XtraReport
    {
        //Datasource.dsReportTableAdapters.AppOptionsTableAdapter adpOptions = new Datasource.dsReportTableAdapters.AppOptionsTableAdapter();
        //Datasource.dsReportTableAdapters.XRep_01ATableAdapter adp_A = new Datasource.dsReportTableAdapters.XRep_01ATableAdapter();
        //Datasource.dsReportTableAdapters.XRep_01BTableAdapter adp_B = new Datasource.dsReportTableAdapters.XRep_01BTableAdapter();
        Datasource.dsLinq.dsLinqQryDataContext dsLinq = new Datasource.dsLinq.dsLinqQryDataContext();
        Datasource.dsQryTableAdapters.QueriesTableAdapter adpQry = new Datasource.dsQryTableAdapters.QueriesTableAdapter();
        public XRep_04()
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

        private void XRep_04_ParametersRequestSubmit(object sender, ParametersRequestEventArgs e)
        {
            if (e.ParametersInformation[0].Parameter.Value == null)
                return;
            long geha = Convert.ToInt64(e.ParametersInformation[0].Parameter.Value);
            xRep_04TableAdapter.Fill(dsReport.XRep_04, geha);
        }
       
        
    }
}
