﻿using System;
using SQLite;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SPID2Deconnecte
{
    public partial class FormHome : Form
    {
        // Declare the dialog.
        private PrintDialog printDialog1;
       

        public FormHome()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void configurerLimprimanteToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void aProposDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void toolStripButtonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void importRéférentielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormImportReferentiel importReferentiel = new FormImportReferentiel();
            importReferentiel.ShowDialog(); 
        }

        private void miseÀJourDeLaBaseDeDonnéeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Création de la base de donnée vide

            /*
             * SPIDD2ConnectionString
             */
            String commandStr;

            // Instanciation de notre connexion
            SQLiteConnection connection = new SQLiteConnection( SingletonOutils.CONNECTION_STRING);

            try
            {
                // BAREME
                commandStr = "DROP TABLE IF EXISTS BAREME;";
                connection.Execute(commandStr);

                commandStr = "CREATE TABLE BAREME ( BAR_CD TEXT NOT NULL, BAR_LB  TEXT NOT NULL, BAR_LB_COURT TEXT, BAR_ID INTEGER NOT NULL, " +
                    "ORGA_IDINTEGER NOT NULL, BAR_NB_JOUEUR INTEGER, BL_MAJ INTEGER, CONSTRAINT PK_BAREME PRIMARY KEY(BAR_ID) );";
                connection.Execute(commandStr);

            }
            catch (SqlException ae)
            {
                MessageBox.Show(ae.Message.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
