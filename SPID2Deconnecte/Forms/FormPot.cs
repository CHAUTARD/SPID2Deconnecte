/*
 * Crée par SharpDevelop.
 * Utilisateur: CHAUTARD
 * Date: 13/12/2019
 * Heure: 08:01
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */

using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

using SPID2Deconnecte.Modeles;

namespace SPID2Deconnecte.Forms
{
    public partial class FormPot : Form
    {
        private Division DivisionSel;

        public FormPot(FormHome formHome)
        {
            DivisionSel = formHome.DivisionSel;

            InitializeComponent();

            // Mettre à jour certain champ
            for(int i = 0; i <24; i++)
            {
                ComboBoxDebut.Items.Add(string.Format("{0,18:00}h00", i));
                ComboBoxDebut.Items.Add(string.Format("{0,18:00}h30", i));
            }
            ComboBoxDebut.Text = "10h00";

            for (int i = 1; i < 9; i++)
            {
                comboBoxNbTableMontees.Items.Add(string.Format("{0}", i));
                ComboBoxTablesAffichees.Items.Add(string.Format("{0}",i));
            }
            comboBoxNbTableMontees.Text = "4";
            ComboBoxTablesAffichees.Text = "4";
            ComboBoxIntervalle.Text = "30 mn";

            
            textBoxLibelle.Text = DivisionSel.DIV_LB;
            dateTimePicker1.Value = DivisionSel.DIV_DT_TOUR;
        }

        private void ButtonSauver_Click(object sender, EventArgs e)
        {
            string imgPath = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "Images" + Path.DirectorySeparatorChar;
            ButtonSauver.Image.Dispose();
            ButtonSauver.Tag = ("Validate".CompareTo(ButtonSauver.Tag) == 0 ? "Fire" : "Validate");
            Bitmap bm = new Bitmap(Path.Combine(imgPath, ButtonSauver.Tag.ToString() + "_64.png"));
            ButtonSauver.Image = bm;
        }
    }
}
