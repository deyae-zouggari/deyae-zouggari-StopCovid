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
    public partial class Form3 : Form
    {
    static string chaine = @"Data Source=DESKTOP-D7HHOO9;Initial Catalog=StopCovid;Integrated Security=True";
        //"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\App_Data\VotreBD.mdf;Integrated Security=True;User Instance=True"
        //"Server=.\SQLEXPRESS; DataBase=VotreBD;USER ID=sa; PASSWORD="
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
      
        public Form3()
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
         private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "select Nom,Prenom,Age,CIN,Malad,Vaccine,pictur from Personne where CIN='"+textBox1.Text+"'";
            SqlDataReader reader = cmd.ExecuteReader();
            
            reader.Read();
            textBox2.Text = reader.GetString(0);
            textBox3.Text = reader.GetString(1);
            textBox4.Text = reader["Age"].ToString();
            textBox5.Text = reader.GetString(3);
            textBox6.Text = reader.GetString(4);
            textBox7.Text = reader.GetString(5);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
           
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["pictur"]);

                pictureBox1.Image = new Bitmap(ms);
            
            cnx.Close();
        }
    }
}
