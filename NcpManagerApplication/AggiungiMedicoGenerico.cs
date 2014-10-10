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
    public partial class AggiungiMedicoGenerico : Form
    {


        public AggiungiMedicoGenerico()
        {
            InitializeComponent();
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
        }

        private void btnPulisci_Click(object sender, EventArgs e)
        {
            txtCognome.Text = "";
            txtNome.Text = "";
            this.errorProvider1.SetError(txtCognome, null);
            this.errorProvider1.SetError(txtNome, null);
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                NcpManagerDbDataContext db = new NcpManagerDbDataContext();
                MedicoGenerico mg = new MedicoGenerico();
                mg.Nome = txtNome.Text;
                mg.Cognome = txtCognome.Text;

                try
                {
                    //db.MedicoGenericos.InsertOnSubmit(mg);
                    //db.SubmitChanges();
                    MessageBox.Show("Medico inserito con successo!","Nuovo Medico Generico",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                    txtCognome.Text = "";
                    txtNome.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Si è verificato il seguente errore: " + ex.Message,"Errore",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                if ((!string.IsNullOrEmpty(errorProvider1.GetError(txtNome))) && (!string.IsNullOrEmpty(errorProvider1.GetError(txtCognome))))
                {
                    MessageBox.Show(errorProvider1.GetError(txtNome) + "\n" + errorProvider1.GetError(txtCognome), "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else if (!string.IsNullOrEmpty(errorProvider1.GetError(txtNome)))
                {
                    MessageBox.Show(errorProvider1.GetError(txtNome), "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show(errorProvider1.GetError(txtCognome), "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
               
            }


        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.txtNome.Text))
            {
                //This control fails validation: Name cannot be empty.
                cancel = true;
                this.errorProvider1.SetError(this.txtNome, "Devi inserire il Nome!");
            }
            e.Cancel = cancel;
        }

        private void txtNome_Validated(object sender, EventArgs e)
        {
            //Control has validated, clear any error message.
            this.errorProvider1.SetError(this.txtNome, string.Empty);
            this.errorProvider1.SetError(this.txtNome, null);
        } 

        private void txtCognome_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.txtCognome.Text))
            {
                //This control fails validation: Name cannot be empty.
                cancel = true;
                this.errorProvider1.SetError(this.txtCognome, "Devi inserire il Cognome!");
            }
            e.Cancel = cancel;
        }

        private void txtCognome_Validated(object sender, EventArgs e)
        {
            //Control has validated, clear any error message.
            this.errorProvider1.SetError(this.txtCognome, string.Empty);
            this.errorProvider1.SetError(this.txtCognome, null);
        } 
    }
}
