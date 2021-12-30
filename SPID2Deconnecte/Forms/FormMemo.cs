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
            Memo memo = new Memo();
            TextBoxMemo.Text = memo.Read();
        }

        private void FormMemo_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Suppression des enregistrement si il existent
            // Sauvegarde des informations
            Memo memo = new Memo();
            memo.Insert(TextBoxMemo.Text);
        }
    }
}
