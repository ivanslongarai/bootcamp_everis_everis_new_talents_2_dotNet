using System;
using System.Windows.Forms;

using AccessControl.Services;

namespace AccessControl.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private async void btnSincronizar_Click(object sender, EventArgs e)
        {
            var synchronizer = new SynchronizeService();

            Cursor = Cursors.WaitCursor;
            await synchronizer.Synchronize();
            Cursor = Cursors.Default;

            MessageBox.Show("A sincronização finalizou com sucesso", "Sincronização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            var frm = new frmStarshipControl();
            frm.ShowDialog();
        }
    }
}
