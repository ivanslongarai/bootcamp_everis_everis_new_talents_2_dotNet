
using AccessControl.Dao;
using AccessControl.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessControl.Forms
{
    public partial class frmRegisterInOut : Form
    {
        private Pilot _pilot;
        private Pilot _pilotCommander;
        private Starship _starship;
        private int _id_Starship;
        private int _idPilot;
        private bool _arriving;
        private bool _pilotTraveling;

        public frmRegisterInOut(int idStarship, int idPilot, bool arriving)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            _id_Starship = idStarship;
            _idPilot = idPilot;
            _arriving = arriving;            

            InitializeComponent();
        }

        private async void frmRegisterInOut_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int? idPilotCommander;
            using (var starshipDao = new StarShipDao())
            {
                _starship = await starshipDao.GetById(_id_Starship);
                idPilotCommander = await starshipDao.GetCommander(_id_Starship);
            }

            using (var pilotoDao = new PilotDao())
            {
                _pilot = await pilotoDao.GetById(_idPilot);
                _pilotTraveling = await pilotoDao.IsPilotTraveling(_idPilot);

                if(idPilotCommander.HasValue)
                    _pilotCommander = await pilotoDao.GetById(idPilotCommander.Value);
            }

            lvAlerts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvAlerts.PerformLayout();

            FillStarshipData();
            FillPilotData();

            if (isValid())
            {
                btnRegister.Enabled = true;
                this.Height = 228;
            }
            else
            {
                btnRegister.Enabled = false;
                this.Height = 490;
            }

            if (_arriving)
                btnRegister.Text = "Registrar Chegada";
            else
                btnRegister.Text = "Registrar Saída";

            Cursor = Cursors.Default;
        }

        private void FillStarshipData()
        {
            txtStarshipName.Text = _starship.Name;
            txtStarshipModel.Text = _starship.Model;
            txtStarshipClass.Text = _starship.StarshipClass;
        }

        private void FillPilotData()
        {
            txtPilotName.Text = _pilot.Name;
            txtBirthYear.Text = _pilot.BirthYear;
            txtPlanetName.Text = _pilot.Planet.Name;
        }

        private bool isValid()
        {
            bool isValid = PilotIsValid();
            isValid = isStarshipValid() && isValid;

            return isValid;
        }

        private bool PilotIsValid()
        {
            bool isValid = true;
            
            if (!_arriving)
            {
                if (_pilotTraveling)
                {
                    isValid = false;
                    lvAlerts.Items.Add(new ListViewItem("PERIGO - PILOTO AINDA NÃO CHEGOU DE VIAGEM, DEVE SER UM IMPOSTOR"));
                }

                if(!_pilot.Starships.Any(starship => starship.Id == _starship.Id))
                {
                    isValid = false;
                    lvAlerts.Items.Add(new ListViewItem("Este piloto não está habilitado para esta nave"));
                }
            }

            if (_arriving && !_pilotTraveling)
            {
                isValid = false;
                lvAlerts.Items.Add(new ListViewItem("PERIGO - PILOTO NÃO SAIU PARA VIAGEM, DEVE SER UM IMPOSTOR"));
            }
            
            return isValid;
        }

        private bool isStarshipValid()
        {
            bool isValid = true;
            if(!_arriving && _pilotCommander != null)
            {
                isValid = false;
                lvAlerts.Items.Add(new ListViewItem("Nave já está em viagem"));
            }

            if (_arriving)
            {
                if (_pilotCommander == null)
                {
                    isValid = false;
                    lvAlerts.Items.Add(new ListViewItem("PERIGO - NAVE NÃO SAIU, PODE SER UMA NAVE IMPOSTORA"));
                }

                if(_pilotCommander != null && _pilotCommander.Id != _pilot.Id)
                {
                    isValid = false;
                    lvAlerts.Items.Add(new ListViewItem($"PERIGO - PILOTO QUE RETIROU A NAVE FOI '{_pilotCommander.Name.ToUpper()}'"));
                }
            }

            return isValid;
        }

        private void frmRegisterInOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (_arriving)
                await RegisterArrive();
            else
                await RegisterDeparture();

            btnRegister.Enabled = false;

            MessageBox.Show("Registro efetuado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async Task RegisterArrive()
        {
            using (var pilotDao = new PilotDao())
                await pilotDao.RegisterTravelEnd(_idPilot, _id_Starship);
        }

        private async Task RegisterDeparture()
        {
            using (var pilotDao = new PilotDao())
                await pilotDao.RegisterTravelStart(_idPilot, _id_Starship);
        }
    }
}
