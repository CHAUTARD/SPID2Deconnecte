using System;
using System.Windows.Forms;
using SPID2Deconnecte.Forms;
using SPID2Deconnecte.Modeles;
using System.Drawing;
using MySql.Data.MySqlClient;
using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace SPID2Deconnecte
{
    public partial class FormHome : Form
    {
        private const string ROOT = "ROOT";

        private const int IM_ROOT = 0;
        private const int IM_EPREUVE = 1;
        private const int IM_DIVISION_ON = 2;
        private const int IM_PRESENT_OFF = 3;
        private const int IM_PRESENT_ON = 4;
        private const int IM_DIVISION_OFF = 5;

        // Declare the dialog.
        private PrintDialog printDialog1;

        // Division séléctionnée
        internal Division DivisionSel { get; set; }

        // Node Sélectionné
        internal TreeNode NodeSel { get; set; }

        // TreeView Font
        Font boldFont = null;
        Font normalFont = null;

        public FormHome()
        {
            InitializeComponent();

            // Titre de la fenêtre
            Text += " - Version : " + System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();

            MajTree();

            // Gestion de la division séléctionnée
            NodeSel = null;
            boldFont = new Font(TreeViewEpreuve.Font, FontStyle.Bold);
            normalFont = new Font(TreeViewEpreuve.Font, FontStyle.Regular);
        }

        private void MajTree()
        {
            // Vider toute la TreeView avant de la re-remplir
            TreeViewEpreuve.Nodes.Clear();

            // Recherche si une ou des épreuves existent
            TreeViewEpreuve.BeginUpdate();

            TreeNode tnRoot, tnEpreuve, tnDivision;

            tnRoot = AddTreeViewNode(TreeViewEpreuve.Nodes, "Liste des épreuves", IM_ROOT, new FactoryData(ROOT));

            using (MySqlConnection connection = DBUtils.GetDBConnection())
            {
                IEnumerable<Epreuve> epreuves = connection.Query<Epreuve>("SELECT * FROM EPREUVE ORDER BY EPRV_LB");

                foreach (Epreuve epreuve in epreuves)
                { 
                    tnEpreuve = AddTreeViewNode(tnRoot.Nodes, epreuve.EPRV_LB, IM_EPREUVE, epreuve);

                    // Rechercher les divisions pour cet épreuve
                    IEnumerable<Division> divisions = connection.Query<Division>(string.Format("SELECT DIV_ID, DIV_LB, ORGA_LB FROM DIVISION LEFT JOIN ORGANISME USING(ORGA_ID) WHERE EPRV_ID= {0} ORDER BY DIV_LB;", epreuve.EPRV_ID));
                    foreach(Division division in divisions)
                    {
                        Organisme organisme = (Organisme)connection.Query<Organisme>("SELECT * FROM ORGANISME WHERE ORGA_ID = " + division.ORGA_ID);
                        tnDivision = AddTreeViewNode(tnEpreuve.Nodes, string.Format("{0} ({1}", division.DIV_LB, organisme.ORGA_LB), IM_DIVISION_OFF, division);

                        // Recherche les joueurs pour cet division
                        // EPREUVE -> DIVISION -> TOUR -> INSCRIT -> JOUEUR -> LICENCIE
                        Tour tour = (Tour)connection.Query<Tour>("SELECT * FROM INSCRIPTION WHERE TOUR_ID = " + division.DIV_ID.ToString());
                            
                        if (tour.TOUR_ID > 0)
                        {
                            Inscription inscription = (Inscription)connection.Query<Inscription>("SELECT * FROM INSCRIPTION WHERE TOUR_ID = " + tour.TOUR_ID.ToString());

                            Joueur joueur = (Joueur)connection.Query<Joueur>("SELECT * FROM `joueur` WHERE JOUE_ID = " + inscription.JOUE_ID.ToString());

                            Licencie licencie = (Licencie)connection.Query<Licencie>("SELECT * FROM `licencie` WHERE LIC_ID = " + joueur.LIC_ID.ToString()); 

                            if (licencie != null)
                            {
                                int img = joueur.PRESENT ? IM_PRESENT_ON : IM_PRESENT_OFF;

                                AddTreeViewNode(tnDivision.Nodes, string.Format("{0} {1}", licencie.PERS_LB_NOM, licencie.PERS_LB_PRENOM), img, joueur);
                            }
                        }
                    }
                }

                connection.Close();
                connection.Dispose();
            }
                

            TreeViewEpreuve.EndUpdate();

            TreeViewEpreuve.ExpandAll();
        }

        // Add a new node to the collection.
        private TreeNode AddTreeViewNode(TreeNodeCollection parent_nodes, string text, int image_index, object tag_object)
        {
            TreeNode new_node = parent_nodes.Add(text);
            new_node.ImageIndex = image_index;
            new_node.SelectedImageIndex = image_index;
            new_node.Tag = tag_object;
            return new_node;
        }

        private void TsmiConfigurerImprimante_Click(object sender, EventArgs e)
        {
            printDialog1 = new PrintDialog();
            System.Drawing.Printing.PrintDocument printDocument1 = null;
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // printDocument1.Print();
            }
        }

        private void TsmiAProposDe_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void ToolStripButtonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TsmiQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TsmiImportReferentiel_Click(object sender, EventArgs e)
        {
            FormImportReferentiel importReferentiel = new FormImportReferentiel();
            importReferentiel.ShowDialog();
        }

        private void TsmiMiseAJourDeLaBaseDeDonnee_Click(object sender, EventArgs e)
        {
            // Création de la base de donnée vide
            FormMAJBase frm = new FormMAJBase();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void TsmiImportLicenciésEtClub_Click(object sender, EventArgs e)
        {
            FormImportLicencies  frm = new FormImportLicencies();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void TsmiClub_Click(object sender, EventArgs e)
        {
            FormFindClub frm = new FormFindClub();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void ToolStripButtonClubs_Click(object sender, EventArgs e)
        {
            TsmiClub_Click(sender, e);
        }

        private void TsmiLicencié_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Licenciés");
        }

        private void ToolStripButtonLicenciers_Click(object sender, EventArgs e)
        {
            TsmiLicencié_Click( sender, e);
        }

        private void ToolStripButtonPOT_Click(object sender, EventArgs e)
        {
            FormPot frm = new FormPot(this);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void ImportPackageToolStripMenu_Click(object sender, EventArgs e)
        {
            FormImportPackage frm = new FormImportPackage();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void TsmiImportListeDesInscrits_Click(object sender, EventArgs e)
        {
            FormImportationInscript frm = new FormImportationInscript();
            frm.ShowDialog();
            frm.Dispose();
        }

        #region epreuve
        private void ToolStripButtonEpreuve_Click(object sender, EventArgs e)
        {
            groupBoxEpreuve.Visible = !groupBoxEpreuve.Visible;
        }

        private void TsmiEpreuves_Click(object sender, EventArgs e)
        {
            ToolStripButtonEpreuve_Click(sender, e);
        }

        private void TreeViewEpreuve_MouseDown(object sender, MouseEventArgs e)
        {
            // Make sure this is the right button.
            if (e.Button != MouseButtons.Right) return;


            // Select this node.
            TreeNode node_here = TreeViewEpreuve.GetNodeAt(e.X, e.Y);
            TreeViewEpreuve.SelectedNode = node_here;

            // See if we got a node.
            if (node_here == null) return;

            // See what kind of object this is and
            // display the appropriate popup menu.

            if (node_here.Tag is FactoryData)
            {
                contextMenuRoot.Show(TreeViewEpreuve, new Point(e.X, e.Y));
            }
            else if (node_here.Tag is Epreuve)
            {
                contextMenuEpreuve.Show(TreeViewEpreuve, new Point(e.X, e.Y));
            }
            else if(node_here.Tag is DivisionOrganisation)
            {
                contextMenuDivision.Show(TreeViewEpreuve, new Point(e.X, e.Y));
            }
            else if (node_here.Tag is Joueur)
            {
                // Affichage du menu contextuel
                contextMenuPresent.Show( TreeViewEpreuve, new Point(e.X, e.Y));
            }
        }
        #endregion

        private void ToolStripButtonMAJ_Click(object sender, EventArgs e)
        {
            FormMAJBase frm = new FormMAJBase();
            frm.ShowDialog();
        }

        #region Inscrit

        private void TsmiPresent_Click(object sender, EventArgs e)
        {
            // Mise a jour de la table
            Joueur joueur = TreeViewEpreuve.SelectedNode.Tag as Joueur;
            joueur.SetPresent(1);

            // Mise a jour de l'image
            TreeViewEpreuve.SelectedNode.ImageIndex = IM_PRESENT_ON;
            TreeViewEpreuve.SelectedNode.SelectedImageIndex = IM_PRESENT_ON;
        }

        private void TsmiAbsent_Click(object sender, EventArgs e)
        {
            // Mise a jour de la table
            Joueur joueur = TreeViewEpreuve.SelectedNode.Tag as Joueur;
            joueur.SetPresent(0);

            // Mise a jour de l'image
            TreeViewEpreuve.SelectedNode.ImageIndex = IM_PRESENT_OFF;
            TreeViewEpreuve.SelectedNode.SelectedImageIndex = IM_PRESENT_OFF;
        }

        private void TsmiSupprimerJoueur_Click(object sender, EventArgs e)
        {
            // Mise a jour de la table
            Joueur joueur = TreeViewEpreuve.SelectedNode.Tag as Joueur;
            DBUtils.Delete("joueur", "JOUE_ID", joueur.JOUE_ID, "Joueur supprimé de la division !");

            // Mise a jour de la treeview
            TreeViewEpreuve.SelectedNode.Remove();
        }

        private void TsmiAddEpreuve_Click(object sender, EventArgs e)
        {
            FormEpreuve frm = new FormEpreuve();
            if (frm.ShowDialog() == DialogResult.OK)
                MajTree();

            frm.Dispose();
        }

        private void TsmiSupprimerEpreuve_Click(object sender, EventArgs e)
        {
            // Mise a jour de la table
            Epreuve epreuve = TreeViewEpreuve.SelectedNode.Tag as Epreuve;

            /*
                     public int CountByEpreuveId(long idEpreuve)
        {
            int iRet = DBUtils.Count("division", "EPRV_ID", idEpreuve);
            return iRet;
        }
             */
            using (MySqlConnection connection = DBUtils.GetDBConnection())
            {
                dynamic result = connection.Query("SELECT COUNT(*) as Count FROM division WHERE  EPRV_ID = " + epreuve.EPRV_ID).Single();

                if (result.Count == 0)
                {
                    if (MessageBox.Show("Voulez vous supprimer cette épreuve ?", "Suppression épeuve", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        connection.Execute("DELETE FROM epreuve WHERE EPRV_ID = " + epreuve.EPRV_ID);
                        connection.Close();
                    }

                    MajTree();
                }
                else
                {
                    // Suppression impossible !
                    MessageBox.Show("Il est impossible de supprimer une épreuve qui posséde des divisions rattachées !", "Suppression impossible !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TsmiConsulterEpreuve_Click(object sender, EventArgs e)
        {
            // Mise a jour de la table
            Epreuve epreuve = TreeViewEpreuve.SelectedNode.Tag as Epreuve;

            FormEpreuve frm = new FormEpreuve("UPDATE");
            frm.SetData(epreuve);

            if (frm.ShowDialog() == DialogResult.OK)
                MajTree();

            frm.Dispose();
        }
        #endregion

        #region Division
        private void TmsiConsulterModifierDivision_Click(object sender, EventArgs e)
        {
            Division division = TreeViewEpreuve.SelectedNode.Tag as Division;

            FormDivision frm = new FormDivision("VIEW");
            frm.SetData(division);
            if (frm.ShowDialog() == DialogResult.OK)
                MajTree();

            frm.Dispose();
        }

        private void TsmiAjouterInscrit_Click(object sender, EventArgs e)
        {

        }

        private void TsmiSupprimerDivision_Click(object sender, EventArgs e)
        {
            // Mise a jour de la table
            Division division = TreeViewEpreuve.SelectedNode.Tag as Division;

            using (MySqlConnection connection = DBUtils.GetDBConnection())
            {
                dynamic result = connection.Query("SELECT COUNT(*) as Count FROM division WHERE EPRV_ID = " + division.DIV_ID).Single();

                if (result.Count == 0)
                {
                    if (MessageBox.Show("Voulez vous supprimer cette division ?", "Suppression division", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        connection.Query("DELETE FROM division WHERE DIV_ID = " + division.DIV_ID);

                        MajTree();
                    }
                    else
                    {
                        // Suppression impossible !
                        MessageBox.Show("Il est impossible de supprimer une division qui posséde des inscrits rattachés !", "Suppression impossible !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                connection.Close();
            }
        }
        #endregion

        private void ToolStripButtonMemo_Click(object sender, EventArgs e)
        {
            FormMemo frm = new FormMemo();
            frm.ShowDialog();
        }

        private void TsmiSelectionner_Click(object sender, EventArgs e)
        {
            // Remise à zéro de l'ancienne sélection
            if(NodeSel != null)
            {
                NodeSel.ImageIndex = IM_DIVISION_OFF;
                NodeSel.SelectedImageIndex = IM_DIVISION_OFF;
                NodeSel.NodeFont = normalFont;
                NodeSel.ForeColor = Color.Black;
            }

            // Nouvelle sélection
            NodeSel = TreeViewEpreuve.SelectedNode;
            DivisionSel = NodeSel.Tag as Division;
            
            NodeSel.ImageIndex = IM_DIVISION_ON;
            NodeSel.SelectedImageIndex = IM_DIVISION_ON;
            NodeSel.NodeFont = boldFont;
            NodeSel.ForeColor = Color.OrangeRed;

            ToolStripButtonPOT.Enabled = true;
        }

        private void TsmiAddDivision_Click(object sender, EventArgs e)
        {
            Epreuve epreuve = TreeViewEpreuve.SelectedNode.Tag as Epreuve;

            FormDivision frm = new FormDivision("CREER", epreuve.EPRV_ID);
            if (frm.ShowDialog() == DialogResult.OK)
                MajTree();

            frm.Dispose();
        }
    }
}
