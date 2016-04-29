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
    public partial class tbl_maradiyEditFrm : DevExpress.XtraEditors.XtraForm
    {
        Datasource.dsLinq.dsLinqQryDataContext dsLinq = new Datasource.dsLinq.dsLinqQryDataContext();
        Datasource.dsData.tbl_maradiyRow _row;
        
        Datasource.dsQryTableAdapters.QueriesTableAdapter AdpQry = new Datasource.dsQryTableAdapters.QueriesTableAdapter();
        Datasource.dsDataTableAdapters.tbl_maradiyTableAdapter adp = new Datasource.dsDataTableAdapters.tbl_maradiyTableAdapter();
        
        Datasource.dsLinq.vtbl_maradiy _vrow = null;
        public tbl_maradiyEditFrm(Datasource.dsLinq.vtbl_maradiy row)
        {
            InitializeComponent();
            _vrow = row;
            adp.FillByID(dsData.tbl_maradiy, _vrow.mid);
            if (dsData.tbl_maradiy.Count != 1)
                Close();
            _row = dsData.tbl_maradiy[0];
        }
        private void tblmortabatAddFrm_Load(object sender, EventArgs e)
        {
            LSMSEmp.QueryableSource = from q in dsLinq.vTBL_Emps select q;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxvp.Validate())
                return;
            try
            {
                _row.userin = Convert.ToInt32(FXFW.SqlDB.UserInfo.UserID);
                _row.datein = (DateTime)AdpQry.GetServerDatetime();
                //dsData.tblmortabat.EndLoadData();
                _row.EndEdit();
                if (adp.Update(dsData.tbl_maradiy) > 0)
                    DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}