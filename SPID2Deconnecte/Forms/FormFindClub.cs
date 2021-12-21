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

        private bool cancelDeletion = false;

        public FormFindClub()
        {
            InitializeComponent();

            DataGridViewClub.Top = menuStrip1.Height;
        }

        private void FormFindClub_Load(object sender, EventArgs e)
        {
            PopulateData();

            DataGridViewClub.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DataGridViewClub.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DataGridViewClub.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewClub.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewClub.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void ToolStripTextBoxNum_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }
        private void ToolStripTextBoxNom_TextChanged_1(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            DataView dv = dTable.DefaultView;

            string strNum = ToolStripTextBoxNum.Text;
            string strNom = ToolStripTextBoxNom.Text;


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
            DataGridViewClub.DataSource = dv;

            SetNbr();
        }

        private void SetNbr()
        {
            ToolStripTextBoxNbr.Text = dTable.DefaultView.Count.ToString();
        }

        private void DataGridViewClub_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (DataGridViewClub.SelectedRows.Count > 0)
            {
                // This is the first row being deleted.
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row(s)?", "Confirm Deletion", MessageBoxButtons.OKCancel);
                if(result == DialogResult.Cancel)
                    return; 
            }

            e.Cancel = cancelDeletion;

            if (DataGridViewClub.SelectedRows.Count == 1)
            {
                // This is the last row being deleted.
                cancelDeletion = false;
            }
            SetNbr();
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            TextBoxClubId.Enabled = true;
            TextBoxClubId.Text = string.Empty;
            comboBoxType.SelectedIndex = 0;
            TextBoxLibelleCourt.Text = string.Empty;
            TextBoxLibelleLong.Text = string.Empty;

            // Bouton enregistrer et supprimer non actif
            ButtonSave.Enabled = false;
            ButtonDel.Enabled = false;
        }

        private void DataGridViewClub_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            TextBoxClubId.Enabled = false;
            TextBoxLibelleLong.Enabled = true;
            TextBoxLibelleCourt.Enabled = true;
            comboBoxType.Enabled = true;

            ButtonDel.Enabled = true;

            // Get the currently selected row using the SelectedRow property.
            DataGridViewSelectedRowCollection selRows = DataGridViewClub.SelectedRows;

            if (selRows.Count == 1)
            {
                foreach (DataGridViewRow row in selRows)
                {
                    TextBoxClubId.Text = row.Cells[1].Value.ToString();
                    TextBoxLibelleLong.Text = row.Cells[2].Value.ToString();
                    TextBoxLibelleCourt.Text = row.Cells[3].Value.ToString();
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

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            string str = TextBoxClubId.Text.Trim();
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
            ToolStripTextBoxNum.Text = string.Empty;
            ToolStripTextBoxNom.Text = string.Empty;

            TextBoxClubId.Enabled = false;
            TextBoxClubId.Text = string.Empty;

            comboBoxType.Enabled = false;
            comboBoxType.SelectedIndex = 0;

            TextBoxLibelleLong.Enabled = false;
            TextBoxLibelleLong.Text = string.Empty;

            TextBoxLibelleCourt.Enabled = false;
            TextBoxLibelleCourt.Text = string.Empty;

            SetNbr();
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

            DataGridViewClub.DataSource = dTable;
        }

        private void TextBoxClubId_TextChanged(object sender, EventArgs e)
        {
            // Seulement si le numero est rempli
            string str = TextBoxClubId.Text.Trim();

            ButtonSave.Enabled = ButtonDel.Enabled = str.Length > 0;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            // Completer le numero de club avec des zéro devant
            int.TryParse(TextBoxClubId.Text, out int i);
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
                    club.CLUB_LB_LONG = TextBoxLibelleLong.Text.Trim();
                    club.CLUB_LB_COURT = TextBoxLibelleCourt.Text.Trim();

                    // créate
                    db.Insert("CLUB", "CLUB_ID", club);

                    MessageBox.Show("Le club est créé !");
                }
                else
                {
                    club.CLUB_LB_LONG = TextBoxLibelleLong.Text.Trim();
                    club.CLUB_LB_COURT = TextBoxLibelleCourt.Text.Trim();

                    db.Update("CLUB", "CLUB_ID", club);

                    MessageBox.Show("Le club est modifié !");
                }
            }

            PopulateData();
            ClearControls();
        }
    }   
}
