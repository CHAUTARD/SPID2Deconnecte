using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPID2Deconnecte.Forms
{
    public partial class FormMAJBase : Form
    {
        public FormMAJBase()
        {
            InitializeComponent();

            ButtonImport.Enabled = false;

            webBrowser1.DocumentText = "<html><body><center><h2> Sauvegarde et création d'une base de donnée vide</h2></center>" +
                "<ul><li> Sauvegarde de la base de donnée actuelle el SPID2D_YYYYMMJJ.</li>" +
                "<li> Supression de la base SIPD2D.</li>" +
                "<li> Importation d'une base vierge.</li></ul>" +
                "<center><h3><FONT COLOR = \"#ff0000\"> Attention! L'opération inverse doit être faite manuellement.</FONT></h3></center>" +
                "<center><FONT COLOR = \"#0000ff\">Un clic sur l'image pour confirmer la Mise à jour.</FONT></center>" +
                "</body></html>";
        }

        private void ButtonAbandon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonImport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            // Copy du fichier avec son nouveau nom
            string newName = string.Format("{0}_{1}{2}", SingletonOutils.DB_FILE, DateTime.Now.ToString("yyyyMMdd"), SingletonOutils.DB_EXTENSION);
            File.Copy( 
                Path.Combine(Directory.GetCurrentDirectory() + SingletonOutils.REP_DB + Path.DirectorySeparatorChar, SingletonOutils.DB_NAME), 
                Path.Combine(Directory.GetCurrentDirectory() + SingletonOutils.REP_DB + Path.DirectorySeparatorChar, newName), true);

            try
            {
                string script = File.ReadAllText(Directory.GetCurrentDirectory() + SingletonOutils.REP_DB + Path.DirectorySeparatorChar + "SPID2D_VIDE.sql");

                // split script on GO command
                IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

                using (var db = new PetaPoco.Database("SqliteConnect"))
                {
                    //Connection.Open();
                    foreach (string commandString in commandStrings)
                    {
                        if (!string.IsNullOrWhiteSpace(commandString.Trim()))
                        {
                            db.ExecuteNonQueryProcAsync(commandString);
                        }
                    }
                    //Connection.Close();
                }
                MessageBox.Show("Mise à jour de la base terminée !");

                Cursor.Current = Cursors.Default;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Cursor.Current = Cursors.Default;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            ButtonImport.Enabled = true;
        }
    }
}
