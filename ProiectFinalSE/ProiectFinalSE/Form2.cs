using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectFinalSE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelQst.Visible = true;
            possAns.Visible = true;
            labelQst.Text = "1. Ce fel de clima preferati?";
            possAns.Items.Add("Calda");
            possAns.Items.Add("Rece");
            possAns.Items.Add("Temperata");
        }

        private void buttNextQ_Click(object sender, EventArgs e)
        {
            if (possAns.CheckedItems.Count == 1)
            {
                String responseItem = "";
                for (int i = 0; i < possAns.Items.Count; i++)
                {
                    if (possAns.GetItemChecked(i))
                    {
                        responseItem = possAns.Items[i].ToString();
                    }
                }
                Program.nextQuestionAndParse(responseItem);
            }
            else 
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult zeroItemsCheked = MessageBox.Show("Va rugam sa selectiati un singur raspuns!", "Eroare", buttons);

            }
        }

        private void buttStopQ_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setQuestionsAndAnswersOnForm(String qst, String[] answs)
        {
            labelQst.Text = "";
            possAns.Items.Clear();
            labelQst.Text = qst;
            foreach(String i in answs)
            {
                possAns.Items.Add(i);
            }
        }
    }
}