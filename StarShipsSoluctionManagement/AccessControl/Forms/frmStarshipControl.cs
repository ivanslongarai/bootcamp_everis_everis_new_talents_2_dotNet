using AccessControl.Dao;
using AccessControl.Extensions;
using System;
using System.Windows.Forms;

namespace AccessControl.Forms
{
    public partial class frmStarshipControl : Form
    {
        private readonly PilotDao _pilotDao;
        private readonly StarShipDao _starShipDao;

        public frmStarshipControl()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            _pilotDao = new PilotDao();
            _starShipDao = new StarShipDao();
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(!rdbArriving.Checked && !rdbDeparturing.Checked)
            {
                MessageBox.Show("É preciso informar se a Starship está chegando ou saindo da Estrela da Morte!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvStarship.Rows.Count == 0 || dgvStarship.Rows.GetCountRowsChecked(1) != 1)
            {
                MessageBox.Show("É preciso selecionar apenas uma Starship!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvPilots.Rows.Count == 0 || dgvPilots.Rows.GetCountRowsChecked(1) != 1)
            {
                MessageBox.Show("É preciso selecionar apenas um piloto da nave!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var idPilot = int.Parse(dgvPilots.Rows[dgvPilots.Rows.GetFirstIndexChecked(1)].Cells[0].Value.ToString());
            var idStarship = int.Parse(dgvStarship.Rows[dgvStarship.Rows.GetFirstIndexChecked(1)].Cells[0].Value.ToString());
            var frm = new frmRegisterInOut(idStarship, idPilot, rdbArriving.Checked);
            frm.ShowDialog();
        }

        private void frmStarshipControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            _starShipDao?.Dispose();
            _pilotDao?.Dispose();
            Dispose();
        }

        private async void btnGetStarship_Click(object sender, EventArgs e)
        {
            dgvStarship.Rows.Clear();
            dgvStarship.Columns.Clear();

            if (string.IsNullOrEmpty(txtStarship.Text))
                return;

            Cursor = Cursors.WaitCursor;
            DataGridViewTextBoxColumn idStarship = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn checkStarshipColumn = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn nameStarshipColumn = new DataGridViewTextBoxColumn();

            idStarship.Visible = false;

            idStarship.ReadOnly = true;
            checkStarshipColumn.ReadOnly = false;
            nameStarshipColumn.ReadOnly = true;

            nameStarshipColumn.Width = 500;

            dgvStarship.RowHeadersVisible = false;
            dgvStarship.ColumnHeadersVisible = false;
            dgvStarship.Columns.Add(idStarship);
            dgvStarship.Columns.Add(checkStarshipColumn);
            dgvStarship.Columns.Add(nameStarshipColumn);

            var starships = await _starShipDao.GetByNameLike(txtStarship.Text);
            foreach (var starship in starships)
                dgvStarship.Rows.Add(starship.Id, false, starship.Name);

            dgvStarship.PerformLayout();
            Cursor = Cursors.Default;
        }

        private async void btnGetPilot_Click(object sender, EventArgs e)
        {
            dgvPilots.Rows.Clear();
            dgvPilots.Columns.Clear();

            if (string.IsNullOrEmpty(txtPilot.Text))
                return;

            Cursor = Cursors.WaitCursor;
            DataGridViewTextBoxColumn idPilotColumn = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn checkPilotColumn = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn namePilotColumn = new DataGridViewTextBoxColumn();

            idPilotColumn.Visible = false;

            idPilotColumn.ReadOnly = true;
            checkPilotColumn.ReadOnly = false;
            namePilotColumn.ReadOnly = true;

            namePilotColumn.Width = 500;

            dgvPilots.RowHeadersVisible = false;
            dgvPilots.ColumnHeadersVisible = false;
            dgvPilots.Columns.Add(idPilotColumn);
            dgvPilots.Columns.Add(checkPilotColumn);
            dgvPilots.Columns.Add(namePilotColumn);

            var pilots = await _pilotDao.GetByNameLike(txtPilot.Text);
            foreach (var pilot in pilots)
                dgvPilots.Rows.Add(pilot.Id, false, pilot.Name);

            dgvStarship.PerformLayout();
            Cursor = Cursors.Default;
        }
    }
}
