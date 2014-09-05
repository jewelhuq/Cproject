using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "1234" )
            {
                MessageBox.Show ("Login Successfull ");
                dashboard d = new dashboard();
                d.Show();
                this.Hide();

            }
            else{
               MessageBox.Show ("Invalid Username");
            }
            
        }

    
    }
}
