using Dapper;
using MySql.Data.MySqlClient;
using OfficeOpenXml;
using SPID2Deconnecte.Modeles;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SPID2Deconnecte.Forms
{
    public partial class FormImportationInscript : Form
    {
        public FormImportationInscript()
        {
            InitializeComponent();
        }

        private void ButtonParcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog
            {
                Title = "Select file",
                InitialDirectory = Directory.GetCurrentDirectory() + SingletonOutils.REP_IMPORT,
                FileName = TextBoxUploadFile.Text,
                Filter = "Fichier Excel(*.xls,*.xlsx)|*.xls;*.xlsx|All Files(*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                TextBoxUploadFile.Text = fdlg.FileName;

                TextBoxMessage.Text = "Fichier à importer : " + TextBoxUploadFile.Text + Environment.NewLine;

                ButtonImport.Enabled = true;
            }
        }

        private void ButtonImport_Click(object sender, EventArgs e)
        {
            Import();
            Application.DoEvents();
        }

        private void Import()
        {
            if (TextBoxUploadFile.Text.Trim() != string.Empty)
            {
                // Fichier à importer
                FileInfo existingFile = new FileInfo(TextBoxUploadFile.Text.Trim());

                FromTxt fromTxt = new FromTxt();

                Epreuve epreuve = new Epreuve();
                Joueur joueur = new Joueur();

                MySqlConnection connection = DBUtils.GetDBConnection();

                // Recherche des informations sur l'épreuve
                // SELECT MAX(EPRV_ID) from EPREUVE
                dynamic result = connection.Query("SELECT MAX(EPRV_ID) as Max from EPREUVE").Single();
                long epreuve_id = result.Max;

                //use EPPlus

                // If you use EPPlus in a noncommercial context
                // according to the Polyform Noncommercial license:
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (ExcelPackage package = new ExcelPackage(existingFile))
                {
                    //get the first worksheet in the workbook
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                    // Vérification des colonnes Nombres et licence
                    int colCount = worksheet.Dimension.End.Column;  //get Column Count
                    int rowCount = worksheet.Dimension.End.Row;     //get row count

                    try
                    {
                        if (colCount == 9)
                        {
                            string str = worksheet.Cells[2, 1].Value?.ToString().Trim();

                            if (str.CompareTo("Licence") == 0)
                            {
                                for (int row = 3; row <= rowCount; row++)
                                {
                                    str = worksheet.Cells[row, 1].Value?.ToString().Trim();

                                    //Print data, based on row and columns position
                                    Console.WriteLine(" Row:" + row + " column: 1 - Value:" + str);

                                    // Recherche du joueur dans la table des licenciers
                                    // Get a record
                                    Licencie licencie = (Licencie)connection.Query<Licencie>("SELECT * FROM `licencie` WHERE LIC_ID = " + str);

                                    // Mise a jour de la table des joueurs
                                    if (licencie != null)
                                    {
                                        string sQuery = "INSERT INTO `joueur` (`EPRV_ID`, `LIC_ID`) VALUES ( @epreuveId, @licencieId );";
                                        connection.Execute(sQuery, new { epreuveId = epreuve_id, licencieId = licencie.LIC_ID });

                                        TextBoxMessage.Text += "Lic : " + str + ", Nom :  " + worksheet.Cells[row, 2].Value?.ToString().Trim() + Environment.NewLine;
                                    }
                                }

                                TextBoxMessage.Text += "Terminé.";
                                MessageBox.Show("Importation des joueurs terminée !", "Importation Joueurs");
                            }
                            else
                            {
                                MessageBox.Show("Le fichier ne correspond pas au format attendu : " + str + " !", "Erreur format de fichier");
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Le fichier ne correspond pas au format attendu !", "Erreur format de fichier");
                    }
                }
                ButtonImport.Enabled = false;
                TextBoxUploadFile.Text = "";
            }
        }
    }
}
