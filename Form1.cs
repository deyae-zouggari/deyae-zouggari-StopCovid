using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stopecovideinterface
{

    public partial class Form1 : Form
    {
       public static string Nom ;
       public static string Prenom ;
       public static string Age ;
       public static string CIN ;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();

        }
  

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string check = radioButton1.Text;
                MessageBox.Show(check);
            }
            else if (radioButton2.Checked)
            {
                string check = radioButton2.Text;
                MessageBox.Show(check);
            }
        }

        // public  class citoyen { }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
             Nom = textBox1.Text;
             Prenom = textBox2.Text;
             Age = textBox3.Text;
             CIN = textBox4.Text;

           

        }
    }
}