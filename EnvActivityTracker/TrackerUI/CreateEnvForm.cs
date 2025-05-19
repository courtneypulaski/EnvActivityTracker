using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;
using TrackerLibrary.Data_Access;

namespace TrackerUI
{
    public partial class CreateEnvForm : Form
    {
        public CreateEnvForm()
        {
            InitializeComponent();
        }

        private void createEnvButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm()) 
            {
                if (UniqueCode())
                {
                    EnvironmentModel model = new(envCodeValue.Text.ToUpper(), envNameValue.Text, envDetailsValue.Text);

                    SQLConnector.CreateEnvironment(model);

                    envCodeValue.Text = "";
                    envNameValue.Text = "";
                    envDetailsValue.Text = "";
                }
                else
                {
                    MessageBox.Show("Please enter a unique Environment Code.");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid data.");
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            if (envCodeValue.Text == "" || envCodeValue.Text.Length > 5)
            {
                isValid = false;
            }
            if (envNameValue.Text == "" || envNameValue.Text.Length > 25)
            {
                isValid = false;
            }
            if (envDetailsValue.Text != "" && envDetailsValue.Text.Length > 256)
            {
                isValid = false;
            }
            return isValid;
        }

        private bool UniqueCode()
        {
            return SQLConnector.IsUniqueEnvCode(envCodeValue.Text.ToUpper());
        }
    }
}
