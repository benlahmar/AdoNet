using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tuto1
{
    public partial class addnote : Form
    {
      static   List<user> users;
        public addnote() => InitializeComponent();

        private void addnote_Load(object sender, EventArgs e)
        {
            users = inscription.Users;
            label1.Text += users.Count;
            for(int i=0;i<users.Count;i++)
            comboBox1.Items.Add(users[i].Nom);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nometudiant=comboBox1.SelectedItem.ToString();
            string nommatire = comboBox2.SelectedItem.ToString();
            double note = Double.Parse(textBox1.Text);

            Matiere m = new Matiere();
            m.Libelle = nommatire;
            m.Note = note;
            user ut=null;
            for (int i = 0; i < users.Count; i++)
                if (users[i].Nom == nometudiant)
                {
                    ut = users[i];
                    ((Etudiant)ut).Notes.Add(m);
                    break;
                }
           
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string nometudiant = comboBox1.SelectedItem.ToString();
            Etudiant ut = new Etudiant();
            for (int i = 0; i < users.Count; i++)
                if (users[i].Nom == nometudiant)
                {
                    ut =(Etudiant) users[i];
                    break;
                }

            for (int j = 0; j < ut.Notes.Count; j++)
            {

               
                TreeNode n2 = new TreeNode();
               // n.Text = ""+;
                n2.Text = ut.Notes[j].Note + "";
                TreeNode[] aa = new TreeNode[1];
                aa[0] = n2;
              //  treeView1.Nodes.Add(n2);
                TreeNode n = new TreeNode(ut.Notes[j].Libelle, aa);

                treeView1.Nodes.Add(n);
               
                label4.Text += ut.Notes[j].Libelle+ "" + ut.Notes[j].Note.ToString();


            }
                   
                

        }
    }
}
