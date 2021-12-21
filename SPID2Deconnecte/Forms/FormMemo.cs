using SPID2Deconnecte.Modeles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace SPID2Deconnecte.Forms
{
    public partial class FormMemo : Form
    {
        public FormMemo()
        {
            InitializeComponent();
        }

        private void FormMemo_Load(object sender, EventArgs e)
        {
            // Lecture de l'enregistrement de la table MEMO
            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                // Recherche du joueur dans la table des licenciers
                Memo a = db.FirstOrDefault<Memo>("Select * FROM MEMO LIMIT 1");
                if (a != null)
                {
                    TextBoxMemo.Text = a.MEMO;
                }
            }
        }

        private void FormMemo_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Suppression des enregistrement si il existent
            // Sauvegarde des informations
            using (var db = new PetaPoco.Database("SqliteConnect"))
            {
                db.Execute("DELETE FROM MEMO;");

                string str = TextBoxMemo.Text;
                if (str.Trim().Length > 0)
                {
                    Memo memo = new Memo(str);
                    db.Insert("MEMO", "MEMO_ID", memo);
                }
            }
        }
    }
}
