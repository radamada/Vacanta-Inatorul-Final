using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectFinalSE
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        public void showDestination(String localization_key, String dest)
        {

            string part1_Path = @"Photos\";
            string part2_Path = localization_key + ".jpg";
            string fullPath = Path.GetFullPath(part1_Path + part2_Path);
            pictureBox1.Image = Image.FromFile(fullPath);
            labelDestin.Visible = true;
            pictureBox1.Visible = true;
            this.Show();
            labelDestin.Text = dest;
            
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult closeApp = MessageBox.Show("Daca inchideti acesta fereastra, aplicatia se va inchide complet.\nSunteti sigur ca doriti acest lucru?", "Info", buttons);
            if(closeApp == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {    
                e.Cancel = true;
            }
        }
    }
}
