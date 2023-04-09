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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtnFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtEmergency_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblParking_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (validateForm() == true)
            {
                string text = "";
                text += "Your name is " + txtFirstName.Text + " " + txtLastName.Text + "\n";
                text += "Your email adress is " + txtEmail.Text + "\n";
                text += "The emergency contact is " + txtEmergency.Text + "\n";
                text += cbxNoRoom.Checked ? "No room selected\n" : "";
                text += cbxSingle.Checked ? "Single  room selected\n" : "";
                text += cbxShared.Checked ? "Shared room selected\n" : "";
                if (!cbxNone.Checked)
                {
                    text += "Dietary restrictions: ";
                    text+= cbxVegetarian.Checked ? "vegetarian " : "";
                    text += cbxGluten.Checked ? "gluten allergy " : "";
                    text += cbxLactose.Checked ? "lactose allergy " : "";
                    text += cbxNut.Checked ? "nut allergy " : "";
                    text += cbxShellfish.Checked ? "shellfish allergy " : "";
                    text += "\n";
                }

                text += "You will attend ";
                text += cbxGala.Checked ? "Awards Gala Dinner " : "";
                text += cbxLuncheon.Checked ? "Luncheon " : "";
                text += cbxHall.Checked ? "Town Hall" : "";

                text += cbxYes2.Checked ? "\nYou will see the list" : "\nYou will not see the list";

                MessageBox.Show(text, "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private bool validateForm()
        {

            btnSubmit.Enabled = false;
            String text = "";

            if (txtFirstName.Text.Equals(""))
            {
                text += "Enter your first name\n";
            }

            if(txtLastName.Text.Equals(""))
            {
                text += "Enter your last name\n";
            }

            if (txtEmail.Text.Equals(""))
            {
                text += "Enter your email adress\n";
            }

            if(!cbxFemale.Checked && !cbxMale.Checked)
            {
                text += "Select your gender\n";
            }

            if (cbxFemale.Checked && cbxMale.Checked)
            {
                text += "Select only one gender\n";
            }

            if(txtPhone.Text.Equals(""))
            {
                text += "Ener your phone number\n";
            }

            if (txtEmergency.Text.Equals(""))
            {
                text += "Enter an emergency contact\n";
            }

            if(!cbxYes.Checked && !cbxNo.Checked)
            {
                text += "Do you require parking?\n";
            } 
            
            if(cbxYes.Checked && cbxNo.Checked)
            {
                text += "Invalid parking selection\n";
            }

            if(!cbxSingle.Checked && !cbxShared.Checked && !cbxNoRoom.Checked)
            {
                text += "Select your room preference\n";
            }

            if(cbxSingle.Checked && cbxShared.Checked && cbxNoRoom.Checked)
            {
                text += "Invalid room selection\n";
            }

            if(!cbxNone.Checked && !cbxVegetarian.Checked && !cbxGluten.Checked && !cbxLactose.Checked && !cbxNut.Checked && !cbxShellfish.Checked)
            {
                text += "Select your dietary restrictions\n";
            }

            if (cbxNone.Checked)
            {
                if(cbxVegetarian.Checked || cbxGluten.Checked || cbxLactose.Checked || cbxNut.Checked || cbxShellfish.Checked)
                {
                    text += "Invalid dietary restrictions\n";
                }
            }

            if(!cbxGala.Checked && !cbxLuncheon.Checked && !cbxHall.Checked)
            {
                text += "Select what activities you will attend\n";
            }

            if(!cbxYes2.Checked && !cbxNo2.Checked)
            {
                text += "Do you want to see the list?\n";
            }

             if(cbxYes2.Checked && cbxNo2.Checked)
            {
                text += "Invalid list preference selection\n";
            }            

            if (text.Length > 0)
            {
                MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            btnSubmit.Enabled = true;

            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succes", "Data registered", MessageBoxButtons.OK);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
