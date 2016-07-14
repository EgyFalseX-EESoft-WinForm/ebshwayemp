using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

namespace Employee.XRep
{
    public partial class XRep_12_Frm : DevExpress.XtraEditors.XtraForm
    {
        Datasource.dsLinq.dsLinqQryDataContext dsLinq = new Datasource.dsLinq.dsLinqQryDataContext();
        public XRep_12_Frm()
        {
            InitializeComponent();
            LSMSGeha.QueryableSource = from q in dsLinq.TBLGehaworks select q;
        }

        private void lueGeha_EditValueChanged(object sender, EventArgs e)
        {
            if (lueGeha.EditValue == null)
                return;
            xRep_12_ATableAdapter.Fill(dsReport.XRep_12_A, Convert.ToInt64(lueGeha.EditValue));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Datasource.dsReport.XRep_12_ADataTable tbl = new Datasource.dsReport.XRep_12_ADataTable();
            xRep12ABindingSource.EndEdit();
            foreach (Datasource.dsReport.XRep_12_ARow emp in dsReport.XRep_12_A)
            {
                if (emp.Selected)
                {
                    Datasource.dsReport.XRep_12_ARow row = tbl.NewXRep_12_ARow();
                    row.EmpID = emp.EmpID;
                    row.EMPNAME = emp.EMPNAME;
                    row.EndEdit();
                    tbl.AddXRep_12_ARow(row);
                }
            }
            if (tbl.Count == 0)
            {
                MessageBox.Show("يجب اختيار عنصر علي الاقل", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            XRep.XRep_12 FrmRep = new XRep.XRep_12(tbl);
            Misc.Misc.ShowPrintPreview(FrmRep);
        }
    }
}