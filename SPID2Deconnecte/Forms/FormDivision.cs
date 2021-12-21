using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPID2Deconnecte.Forms
{
    public partial class FormDivision : Form
    {
        public FormDivision()
        {
            InitializeComponent();
        }

        private void ButtonAbandon_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
