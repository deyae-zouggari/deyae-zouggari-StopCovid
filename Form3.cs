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
        public static int day;
        private DateTime endsAt;

  

        // These integer variables store the numbers 
        // for the addition problem. 


        // This integer variable keeps track of the 
        // remaining time.
       

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


        private void textBox1_TextChanged(object sender,EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "select Nom,Prenom,Age,CIN,Malad,Vaccine,dayc from Personne where CIN='" + textBox1.Text + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            //byte[] pictureIdByte;
           // Image pictureIdImg = null;

            reader.Read();
            textBox2.Text = reader.GetString(0);
            textBox3.Text = reader.GetString(1);
            textBox4.Text = reader["Age"].ToString();
            textBox5.Text = reader.GetString(3);
            textBox6.Text = reader.GetString(4);
            textBox7.Text = reader.GetString(5);
            day = reader.GetInt32(6);
            textBox8.Text = day.ToString();

            //pictureIdByte = (byte[])(reader["pictur"]);

            //pictureBox1.Image = pictureIdImg;


            cnx.Close();
            //cnx.Open();
            //cmd.Connection = cnx;
            //cmd.CommandText = "select pictur from Personne where CIN='" + textBox1.Text + "'";
            //DataSet dataSet = new DataSet();
            //adapter.Fill(dataSet);
            //byte[] image = File.ReadAllBytes("pictur");
            //if (dataSet.Tables[0].Rows.Count == 1)
            //{
            //    MemoryStream mem = new MemoryStream("pictur");
            //    pictureBox1.Image = Image.FromStream(mem);
            //}
            //cnx.Close();
            

        }
        // returns today's date
      




        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int secondsRemaining = (int)(endsAt - DateTime.Now).TotalSeconds;
            TimeSpan time = TimeSpan.FromSeconds(secondsRemaining);
            label1.Text = time.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            endsAt = DateTime.Now.AddDays(day);  
        }
    }
}
