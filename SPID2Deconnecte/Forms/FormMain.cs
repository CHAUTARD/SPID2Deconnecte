using System;
using System.Windows.Forms;
using SPID2Deconnecte.Forms;
using SPID2Deconnecte.Modeles;
using System.Drawing;

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

             /*
                Color[] bgColor = new Color[] {
                    ColorTranslator.FromHtml("0xfeceea"),
                    ColorTranslator.FromHtml("0xfef1d2"),
                    ColorTranslator.FromHtml("0xa9fdd8"),
                    ColorTranslator.FromHtml("0xd7f8ff"),
                    ColorTranslator.FromHtml("0xcec5fa")
                };
            */

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
            var db = new PetaPoco.Database("SqliteConnect");

            TreeViewEpreuve.BeginUpdate();

            TreeNode tnRoot, tnEpreuve, tnDivision;

            tnRoot = AddTreeViewNode(TreeViewEpreuve.Nodes, "Liste des épreuves", IM_ROOT, new FactoryData(ROOT));

            foreach (var epreuve in db.Query<EpreuveCrud>("SELECT * FROM EPREUVE ORDER BY EPRV_LB"))
            {
                tnEpreuve = AddTreeViewNode(tnRoot.Nodes, epreuve.EPRV_LB, IM_EPREUVE, epreuve);

                // Rechercher les divisions pour cet épreuve
                foreach (var div in db.Query<DivisionOrganisation>("SELECT DIV_ID, DIV_LB, ORGA_LB FROM DIVISION LEFT JOIN ORGANISME USING(ORGA_ID) WHERE EPRV_ID= " + epreuve.EPRV_ID + " ORDER BY DIV_LB;"))
                {
                    tnDivision = AddTreeViewNode(tnEpreuve.Nodes, string.Format("{0} ({1}", div.DIV_LB, div.ORGA_LB), IM_DIVISION_OFF, div);

                    // Recherche les joueurs pour cet division
                    // EPREUVE -> DIVISION -> TOUR -> INSCRIT -> JOUEUR -> LICENCIE
                    int idTour = db.ExecuteScalar<int>("SELECT TOUR_ID FROM TOUR WHERE DIV_ID = " +div.DIV_ID);
                    var inscriptions = db.Query<Inscription>("SELECT * FROM INSCRIPTION WHERE TOUR_ID = " + idTour);

                    foreach ( var insciption in inscriptions)
                    {
                        var joueur = db.SingleOrDefault <Joueur>("WHERE JOUE_ID = @0", insciption.JOUE_ID);
                        var licencie = db.SingleOrDefault<Licencie>("WHERE LIC_ID = @0 ORDER BY PERS_LB_NOM, PERS_LB_PRENOM", joueur.LIC_ID);

                        if (licencie != null)
                        {
                            int img = joueur.PRESENT == 1 ? IM_PRESENT_ON : IM_PRESENT_OFF;

                            AddTreeViewNode(tnDivision.Nodes, string.Format("{0} {1}", licencie.PERS_LB_NOM, licencie.PERS_LB_PRENOM), img, joueur);
                        }
                    }
                }
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

        private void TsmiQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
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
            joueur.PRESENT = 1;

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Update(joueur);
            }

            // Mise a jour de l'image
            TreeViewEpreuve.SelectedNode.ImageIndex = IM_PRESENT_ON;
            TreeViewEpreuve.SelectedNode.SelectedImageIndex = IM_PRESENT_ON;
        }

        private void TsmiAbsent_Click(object sender, EventArgs e)
        {
            // Mise a jour de la table
            Joueur joueur = TreeViewEpreuve.SelectedNode.Tag as Joueur;
            joueur.PRESENT = 0;

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Update(joueur);
            }

            // Mise a jour de l'image
            TreeViewEpreuve.SelectedNode.ImageIndex = IM_PRESENT_OFF;
            TreeViewEpreuve.SelectedNode.SelectedImageIndex = IM_PRESENT_OFF;
        }

        private void TsmiSupprimerJoueur_Click(object sender, EventArgs e)
        {
            // Mise a jour de la table
            Joueur joueur = TreeViewEpreuve.SelectedNode.Tag as Joueur;

            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Delete(joueur);
            }

            // Mise a jour de la treeview
            TreeViewEpreuve.SelectedNode.Remove();
        }

        #endregion

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

            DivisionCrud divisionCrud = new DivisionCrud();
            if (divisionCrud.CountEpreuve(epreuve.EPRV_ID) == 0)
            {
                if (MessageBox.Show("Voulez vous supprimer cette épreuve ?", "Suppression épeuve", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EpreuveCrud epreuveCrud = new EpreuveCrud();
                    epreuveCrud.Delete(epreuve);

                    MajTree();
                }
            }
            else
            {
                // Suppression impossible !
                MessageBox.Show("Il est impossible de supprimer une épreuve qui posséde des divisions rattachées !", "Suppression impossible !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TsmiConsulterEpreuve_Click(object sender, EventArgs e)
        {
            // Mise a jour de la table
            EpreuveCrud epreuveCrud = TreeViewEpreuve.SelectedNode.Tag as EpreuveCrud;

            FormEpreuve frm = new FormEpreuve("UPDATE");
            frm.SetData(epreuveCrud);

            if (frm.ShowDialog() == DialogResult.OK)
                MajTree();

            frm.Dispose();
        }

        #region Division
        private void TmsiConsulterModifierDivision_Click(object sender, EventArgs e)
        {

        }

        private void TsmiAjouterInscrit_Click(object sender, EventArgs e)
        {

        }

        private void TsmiSupprimerDivision_Click(object sender, EventArgs e)
        {
            // Mise a jour de la table
            Division division = TreeViewEpreuve.SelectedNode.Tag as Division;

            InscriptionCrud inscriptionCurd = new InscriptionCrud();
            if (inscriptionCurd.CountInscitr(division.DIV_ID) == 0)
            {
                if (MessageBox.Show("Voulez vous supprimer cette division ?", "Suppression division", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    inscriptionCurd.Delete();

                    MajTree();
                }
            }
            else
            {
                // Suppression impossible !
                MessageBox.Show("Il est impossible de supprimer une division qui posséde des inscrits rattachés !", "Suppression impossible !", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            FormDivision frm = new FormDivision();
            if (frm.ShowDialog() == DialogResult.OK)
                MajTree();

            frm.Dispose();
        }
    }
}
