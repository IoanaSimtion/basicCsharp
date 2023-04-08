using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basic
{
    public partial class Formular : Form
    {
        public Formular()
        {
            InitializeComponent();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblBasicInfo_Click(object sender, EventArgs e)
        {

        }

        private void lblDesign_Click(object sender, EventArgs e)
        {

        }

        private void buttonData_Click(object sender, EventArgs e)
        {

            if (validateForm() == true)
            {
                string text = "";

                text += "Numele este " + txtNume.Text + "\n";
                text += "Adresa de email este " + txtEmail.Text + "\n";
                text += "Rolul este " + cmbRole.SelectedItem + "\n";
                text += "Marimea tricoului este " + cmbSize.Text + "\n";
                text += "Designul ales este " + cmbTheme.SelectedItem + "\n";
                text += "Culoarea aleasa este " + cmbColor.SelectedItem + "\n";
                MessageBox.Show(text, "exemplu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
           
           
        }


        private bool validateForm() {

            buttonSubmit.Enabled = false;
            String text = "";
            if (txtNume.Text.Equals(""))
            {
                text += "Trebuie sa introduceti numele\n";
            }
        
            if(txtEmail.Text.Equals(""))
            {
                text += "Trebuie sa introduceti adresa de email\n";
            }

            if (cmbRole.SelectedIndex==-1)
            {
                text += "Trebuie sa selectati rolul\n";
            }

            if (cmbSize.SelectedIndex==-1)
            {
                text += "Trebuie sa selectati marimea\n";
            }

            if (cmbTheme.SelectedIndex==-1)
            {
                text += "Trebuie sa selectati designul\n";
            }

            if(cmbColor.SelectedIndex==-1)
            {
                text += "Trebuie sa selectati culoarea\n";
            }

            if (text.Length > 0)
            {

                MessageBox.Show(text, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            buttonSubmit.Enabled = true;

            return true;
        
        }


        private void buttonSubmit_Click(object sender, EventArgs e) 
        {
           
        }

        private void buttonSubmit_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Succes");
        }
    }

}
