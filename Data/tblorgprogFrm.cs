using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Employee.Data
{
    public partial class tblorgprogFrm : DevExpress.XtraEditors.XtraForm
    {
        Datasource.dsLinq.dsLinqQryDataContext dsLinq = new Datasource.dsLinq.dsLinqQryDataContext();
        Datasource.dsQryTableAdapters.QueriesTableAdapter AdpQry = new Datasource.dsQryTableAdapters.QueriesTableAdapter();
        Datasource.dsDataTableAdapters.tblorgprogTableAdapter adp = new Datasource.dsDataTableAdapters.tblorgprogTableAdapter();
        public tblorgprogFrm()
        {
            InitializeComponent();
        }
      
        private void tblmortabatAddFrm_Load(object sender, EventArgs e)
        {
            adp.Fill(dsData.tblorgprog);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxvp.Validate())
                return;
            try
            {
                dsData.tblorgprog[0].EndEdit();
                adp.Update(dsData.tblorgprog);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
       
    }
}