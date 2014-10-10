using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NcpManagerApplication
{
    public partial class Main : Form
    {
        AggiungiMedicoGenerico aggiungiMedicogenericoForm;

        public Main()
        {
            InitializeComponent();
        }

        //Click su Aggiungi Medico Generico
        private void medicoGenericoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aggiungiMedicogenericoForm == null)
            {
                ShowAddMedicoGenerico();
            }

        }

        private void ShowAddMedicoGenerico()
        {
            aggiungiMedicogenericoForm = new AggiungiMedicoGenerico();
            aggiungiMedicogenericoForm.MdiParent = this;
            aggiungiMedicogenericoForm.Text = "Aggiungi Medico Generico";
            aggiungiMedicogenericoForm.WindowState = FormWindowState.Maximized;
            aggiungiMedicogenericoForm.Show();
        }



    }
}
