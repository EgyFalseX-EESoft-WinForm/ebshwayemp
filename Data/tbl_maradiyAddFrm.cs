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
    public partial class tbl_maradiyAddFrm : DevExpress.XtraEditors.XtraForm
    {
        Datasource.dsLinq.dsLinqQryDataContext dsLinq = new Datasource.dsLinq.dsLinqQryDataContext();
        Datasource.dsQryTableAdapters.QueriesTableAdapter AdpQry = new Datasource.dsQryTableAdapters.QueriesTableAdapter();
        Datasource.dsDataTableAdapters.tbl_maradiyTableAdapter adp = new Datasource.dsDataTableAdapters.tbl_maradiyTableAdapter();
        public tbl_maradiyAddFrm()
        {
            InitializeComponent();
        }
        void ResetControls()
        {
            lueEmpID.EditValue = null;
            deteldatae.EditValue = AdpQry.GetServerDatetime();
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
                adp.Insert(Convert.ToInt32(lueEmpID.EditValue), deteldatae.DateTime, null, null, string.Empty, null, string.Empty, Convert.ToInt32(FXFW.SqlDB.UserInfo.UserID), (DateTime)AdpQry.GetServerDatetime());
                if (MessageBox.Show("هل ترغب في طباعة الطلب ؟", "طباعة",  MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                {
                    XRep.XRep_01 FrmRep = new XRep.XRep_01(Convert.ToInt32(lueEmpID.EditValue), deteldatae.DateTime);
                    Misc.Misc.ShowPrintPreview(FrmRep);
                }
                //ResetControls();
                //DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
    }
}