using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace stopecovideinterface
{
    public partial class Form2 : Form
    {
        static string chaine = @"Data Source=DESKTOP-D7HHOO9;Initial Catalog=StopCovid;Integrated Security=True";
        //"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\App_Data\VotreBD.mdf;Integrated Security=True;User Instance=True"
        //"Server=.\SQLEXPRESS; DataBase=VotreBD;USER ID=sa; PASSWORD="
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string imageLocation="";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*jpg| png files(*.png)|*.png| All Files(*.*)|*.* ";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                }
                }
            catch (Exception)
            {
                MessageBox.Show("An error occured");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
           
            //cnx.Open();
            //cmd.Connection = cnx;
            //cmd.CommandText = "insert into Personne(Nom,Prenom,Age,CIN,Malad,Contacteur,Vaccine,QR) values('" +f1.Nom + "','" +f1.Prenom + "','" +Age + "','" + CIN + "','" + etat + "','" + cont + "','" +vac + "','" + QR + "') ";
            //cmd.ExecuteNonQuery();
            //cnx.Close();
        }
    }
}
