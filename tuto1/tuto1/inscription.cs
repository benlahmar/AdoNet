using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace tuto1
{
    public partial class inscription : Form
    {
         static  List<user> users = new List<user>();
        public inscription()
        {
            InitializeComponent();
        }

        internal static List<user> Users { get => users; set => users = value; }

       
        private void button1_Click(object sender, EventArgs ee)
        {
            string rl = comboBox1.SelectedItem.ToString();
            if (rl.Equals("User"))
            {
                user u = new user();
                u.Nom = textBox1.Text;
                u.Log = textBox2.Text;
                u.Pass = textBox3.Text;
                u.Pays = pays.SelectedText;
                u.Ville = ville.SelectedText;

                Users.Add(u);
            }
            else
                if (rl.Equals("Etudiant"))
            {
                Etudiant e = new Etudiant();
                e.Code = textBox4.Text;
                e.Filiere = comboBox2.SelectedItem.ToString();

                e.Nom = textBox1.Text;
                e.Log = textBox2.Text;
                e.Pass = textBox3.Text;
                e.Pays = pays.SelectedText;
                e.Ville = ville.SelectedText;

                Users.Add(e);
            }

            label2.Text = "....." + users.Count;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rl= comboBox1.SelectedItem.ToString();


            if (rl.Equals("Etudiant"))
                panel2.Visible = true;
            else
                panel2.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //acces a la db
            string sconn = " Data Source=Pc-moi;Initial Catalog=mabase2;Integrated Security=True";
            SqlConnection con = new SqlConnection(sconn);
            con.Open();

            string sql = "insert into users values("+ Int32.Parse(textBox5.Text)+", ' "+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+pays.SelectedItem.ToString()+"','"+ville.SelectedItem.ToString()+"')" ;
            SqlCommand cmd = new SqlCommand(sql, con);
            int nb=cmd.ExecuteNonQuery();
            con.Close();
            label2.Text = "..." + nb;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            //acces a la db
            string sconn = " Data Source=Pc-moi;Initial Catalog=mabase2;Integrated Security=True";
            SqlConnection con = new SqlConnection(sconn);
            con.Open();

            string sql = "delete from users where id="+ Int32.Parse(textBox5.Text);
            SqlCommand cmd = new SqlCommand(sql, con);
            int nb = cmd.ExecuteNonQuery();
            con.Close();
            label2.Text = "..." + nb;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //acces a la db
            string sconn = " Data Source=Pc-moi;Initial Catalog=mabase2;Integrated Security=True";
            SqlConnection con = new SqlConnection(sconn);
            con.Open();

            string sql="select * from users where id="+ Int32.Parse(textBox5.Text); 
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rs = cmd.ExecuteReader();

            if (rs.Read())
            {
                textBox1.Text = rs.GetString(1);
                textBox2.Text = rs.GetString(2);
                textBox3.Text = rs.GetString(3);
                pays.SelectedItem = rs.GetString(4);
            }
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            //acces a la db
            string sconn = " Data Source=Pc-moi;Initial Catalog=mabase2;Integrated Security=True";
            SqlConnection con = new SqlConnection(sconn);
            con.Open();

            string sql = "update users set nom='" + textBox1.Text + "', login='" + textBox2.Text + "',pass='" + textBox3.Text + "' where id="+Int32.Parse(textBox5.Text);
            SqlCommand cmd = new SqlCommand(sql, con);
            int nb = cmd.ExecuteNonQuery();
            con.Close();
            label2.Text = "..." + nb;
        }
    }
}
