using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicContent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //CREATE
            Button b;
            b = new Button();

            //CHANGE PROPERTIES
            b.Text = "Some text";
            b.Location = new Point(100, 100);
            b.BackColor = Color.Red;
            //CONNECT METHOD DO EVENT CLICK
            b.Click += B_Click;

            //ADD TO CONTAINER TO SHOW INSIDE
            this.Controls.Add(b);

            //SECOND BUTTON           
            b = new Button();

            //CHANGE PROPERTIES
            b.Text = "Some text";
            b.Location = new Point(200, 200);
            b.BackColor = Color.Blue;
            //CONNECT METHOD DO EVENT CLICK
            b.Click += B_Click;

            //ADD TO CONTAINER TO SHOW INSIDE
            this.Controls.Add(b);
        }

        private void B_Click(object sender, EventArgs e)
        {
            MessageBox.Show("After click!");

            //sender is reference to clicked button
            if(sender is Button)
            {
                (sender as Button).Text = "After Click!";
            }
        }
    }
}
