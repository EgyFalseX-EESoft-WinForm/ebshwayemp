using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace Employee.Data
{
    public partial class tbl_maradiyFrm : XtraForm
    {
        bool _Insert, _Update, _Delete;
        Datasource.dsLinq.dsLinqQryDataContext dsLinq = new Datasource.dsLinq.dsLinqQryDataContext() { ObjectTrackingEnabled = false };
        Datasource.dsDataTableAdapters.tbl_maradiyTableAdapter adp = new Datasource.dsDataTableAdapters.tbl_maradiyTableAdapter();
        #region -   Functions   -
        public tbl_maradiyFrm()
        {
            InitializeComponent();
        }
        private void ActiveKeyDownEvent(object sender, KeyEventArgs e)
        {
            return;
            if (e.KeyData != Keys.F5 && e.KeyData != Keys.F6 && e.KeyData != Keys.F10 && e.KeyData != Keys.F8)
                return;
            switch (e.KeyData)
            {
                case Keys.F1:
                    break;
                case Keys.F5:
                    btnNew_Click(btnNew, new EventArgs());
                    break;
                case Keys.F6:
                    //repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F8:
                    repositoryItemButtonEditDel_ButtonClick(repositoryItemButtonEditDel, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F10:
                    //repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                default:
                    break;
            }
        }
        private void ActivePriv()
        {
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            //SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;

            btnNew.Visible = Inserting;
            //repositoryItemButtonEditSave.Buttons[0].Visible = Updateing;
            repositoryItemButtonEditDel.Buttons[0].Visible = Deleting;

            _Insert = Inserting; _Update = Updateing; _Delete = Deleting;
        }
        #endregion
        #region - Event Handlers -
        private void FormFrm_Load(object sender, EventArgs e)
        {
            LSMSData.QueryableSource = from q in dsLinq.vtbl_maradiys select q;
            //ActivePriv();
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            Datasource.dsLinq.vtbl_maradiy row = (Datasource.dsLinq.vtbl_maradiy)GV.GetRow(GV.FocusedRowHandle);

            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                adp.Delete(row.EmpID, row.teldatae);
                gridViewData.DeleteRow(GV.FocusedRowHandle);
                LSMSData.Reload();
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(ex.Message, true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            tbl_maradiyAddFrm frm = new tbl_maradiyAddFrm();
            frm.ShowDialog();
            LSMSData.Reload();
        }
        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            Datasource.dsLinq.vtbl_maradiy row = (Datasource.dsLinq.vtbl_maradiy)GV.GetRow(GV.FocusedRowHandle);
            tbl_maradiyEditFrm frm = new tbl_maradiyEditFrm(row);
            frm.ShowDialog();
            LSMSData.Reload();
        }
        private void btnPrint1_Click(object sender, EventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            Datasource.dsLinq.vtbl_maradiy row = (Datasource.dsLinq.vtbl_maradiy)GV.GetRow(GV.FocusedRowHandle);
            if (row == null)
                return;
            XRep.XRep_01 FrmRep = new XRep.XRep_01(row.EmpID, row.teldatae);
            Misc.Misc.ShowPrintPreview(FrmRep);
        }
        private void btnPrint2_Click(object sender, EventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            Datasource.dsLinq.vtbl_maradiy row = (Datasource.dsLinq.vtbl_maradiy)GV.GetRow(GV.FocusedRowHandle);
            if (row == null)
                return;
            XRep.XRep_02 FrmRep = new XRep.XRep_02(row.EmpID, row.teldatae);
            Misc.Misc.ShowPrintPreview(FrmRep);
        }
        private void btnPrint3_Click(object sender, EventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            Datasource.dsLinq.vtbl_maradiy row = (Datasource.dsLinq.vtbl_maradiy)GV.GetRow(GV.FocusedRowHandle);
            if (row == null)
                return;
            XRep.XRep_03 FrmRep = new XRep.XRep_03(row.EmpID, (DateTime)row.datefrom, (DateTime)row.dateto);
            Misc.Misc.ShowPrintPreview(FrmRep);
        }
        #endregion

       

        
        

    }
}