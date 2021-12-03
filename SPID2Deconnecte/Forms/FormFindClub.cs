using SPID2Deconnecte.Modeles;
using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SPID2Deconnecte.Forms
{
    public partial class FormFindClub : Form
    {
        public string connString;
        public string query;
        public OleDbDataAdapter dAdapter;
        public System.Data.DataTable dTable;
        public OleDbCommandBuilder cBuilder;
        public DataView myDataView;

        private int? selectedRowCount = 0;
        private bool cancelDeletion = false;

        public FormFindClub()
        {
            InitializeComponent();

            dataGridViewClub.Top = menuStrip1.Height;
        }

        private void FormFindClub_Load(object sender, EventArgs e)
        {
            PopulateData();

            dataGridViewClub.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewClub.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewClub.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewClub.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewClub.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripTextBoxNum_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }
        private void toolStripTextBoxNom_TextChanged_1(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            DataView dv = dTable.DefaultView;

            string strNum = toolStripTextBoxNum.Text;
            string strNom = toolStripTextBoxNom.Text;


            if (strNum.Length == 0)
            {
                // Filtre sur le nom
                if (strNom.Length == 0)
                {
                    dv.RowFilter = String.Empty;
                }
                else
                {
                    dv.RowFilter = "([Nom] LIKE '%" + strNom + "%') OR ([Nom_court] LIKE '%" + strNom + "%')";
                }
            }
            else
            {
                if (strNom.Length == 0)
                {
                    // Filtre seulement sur le numéro
                    dv.RowFilter = "[Num] LIKE '%" + strNum + "%'";
                }
                else
                {
                    // Filtre sur les deux
                    dv.RowFilter = "([Num] LIKE '%" + strNum + "%') AND (([Nom] LIKE '%" + strNom + "%') OR ([Nom_court] LIKE '%" + strNom + "%'))";
                }
            }
            dataGridViewClub.DataSource = dv;

            setNbr();
        }

        private void setNbr()
        {
            toolStripTextBoxNbr.Text = dTable.DefaultView.Count.ToString();
        }

        private void dataGridViewClub_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridViewClub.SelectedRows.Count > 0)
            {
                // This is the first row being deleted.
                selectedRowCount = dataGridViewClub.SelectedRows.Count;
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row(s)?", "Confirm Deletion", MessageBoxButtons.OKCancel);
                if(result == DialogResult.Cancel)
                    return; 
            }

            e.Cancel = cancelDeletion;

            if (dataGridViewClub.SelectedRows.Count == 1)
            {
                // This is the last row being deleted.
                selectedRowCount = 0;
                cancelDeletion = false;
            }
            setNbr();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            textBoxClubId.Enabled = true;
            textBoxClubId.Text = string.Empty;
            comboBoxType.SelectedIndex = 0;
            textBoxLibelleCourt.Text = string.Empty;
            textBoxLibelleLong.Text = string.Empty;

            // Bouton enregistrer et supprimer non actif
            buttonSave.Enabled = false;
            buttonDel.Enabled = false;
        }

        private void dataGridViewClub_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            textBoxClubId.Enabled = false;
            textBoxLibelleLong.Enabled = true;
            textBoxLibelleCourt.Enabled = true;
            comboBoxType.Enabled = true;

            buttonDel.Enabled = true;

            // Get the currently selected row using the SelectedRow property.
            DataGridViewSelectedRowCollection selRows = dataGridViewClub.SelectedRows;

            if (selRows.Count == 1)
            {
                foreach (DataGridViewRow row in selRows)
                {
                    textBoxClubId.Text = row.Cells[1].Value.ToString();
                    textBoxLibelleLong.Text = row.Cells[2].Value.ToString();
                    textBoxLibelleCourt.Text = row.Cells[3].Value.ToString();
                    switch (row.Cells[4].ToString())
                    {
                        case "M":
                            comboBoxType.SelectedIndex = 1;
                            break;

                        default:
                            comboBoxType.SelectedIndex = 0;
                            break;
                    }
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            string str = textBoxClubId.Text.Trim();
            // Vérifier si le numéro du club est rempli
            if (str.Length > 0)
            {
                // Demande de confirmation
                if (MessageBox.Show( "Confirmez-vous la suppression du club n° " + str, "Supprimer un club ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var db = new PetaPoco.Database("SqliteConnect"))
                    {
                        db.Execute(@"DELETE [CLUB] WHERE [CLUB_ID] = @0", str);
                    }
                    MessageBox.Show("Le club est supprimé !");

                    PopulateData();
                    ClearControls();
                }
            }
            else
            {
                MessageBox.Show("Saisir le numéro du club à supprimer !");
            }          
        }

        private void ClearControls()
        {
            toolStripTextBoxNum.Text = string.Empty;
            toolStripTextBoxNom.Text = string.Empty;

            textBoxClubId.Enabled = false;
            textBoxClubId.Text = string.Empty;

            comboBoxType.Enabled = false;
            comboBoxType.SelectedIndex = 0;

            textBoxLibelleLong.Enabled = false;
            textBoxLibelleLong.Text = string.Empty;

            textBoxLibelleCourt.Enabled = false;
            textBoxLibelleCourt.Text = string.Empty;

            setNbr();
        }

        private void PopulateData()
        {
            dTable = new DataTable();

            dTable.Columns.Add("Index", typeof(int));
            dTable.Columns.Add("Num", typeof(string));
            dTable.Columns.Add("Nom", typeof(string));
            dTable.Columns.Add("Nom_court", typeof(string));
            dTable.Columns.Add("Type", typeof(string));

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                var clubs = db.Query<Club>("SELECT * FROM CLUB ORDER BY CLUB_NM");
                foreach (var club in clubs)
                {
                    dTable.Rows.Add(club.CLUB_ID, club.CLUB_NM, club.CLUB_LB_LONG, club.CLUB_LB_COURT, club.CLUB_FG);
                }
            }

            dataGridViewClub.DataSource = dTable;
        }

        private void textBoxClubId_TextChanged(object sender, EventArgs e)
        {
            // Seulement si le numero est rempli
            string str = textBoxClubId.Text.Trim();

            buttonSave.Enabled = buttonDel.Enabled = str.Length > 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Completer le numero de club avec des zéro devant
            int i;
            int.TryParse(textBoxClubId.Text, out i);
            string str = i.ToString("D8");

            // Recherche
            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                Club club = db.SingleOrDefault<Club>("SELECT * FROM CLUB WHERE CLUB_NM=@0", str);

                // Le club existe Update
                if (club == null)
                {
                    club.CLUB_ID = Convert.ToUInt64(i);
                    club.CLUB_NM = str;
                    club.CLUB_LB_LONG = textBoxLibelleLong.Text.Trim();
                    club.CLUB_LB_COURT = textBoxLibelleCourt.Text.Trim();

                    // créate
                    db.Insert("CLUB", "CLUB_ID", club);

                    MessageBox.Show("Le club est créé !");
                }
                else
                {
                    club.CLUB_LB_LONG = textBoxLibelleLong.Text.Trim();
                    club.CLUB_LB_COURT = textBoxLibelleCourt.Text.Trim();

                    db.Update("CLUB", "CLUB_ID", club);

                    MessageBox.Show("Le club est modifié !");
                }
            }

            PopulateData();
            ClearControls();
        }
    }   
}
