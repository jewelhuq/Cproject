using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PetaPoco;
using System.Configuration;




using WindowsFormsApplication1.Entities;


namespace WindowsFormsApplication1
{
    public partial class inform : Form
    {
        public inform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new PetaPoco.Database("accessConnectionString");

            var article = new article();
            article.Name=  ("Jewel");
            object identity = db.Insert(article);
            

        }
    }
}
