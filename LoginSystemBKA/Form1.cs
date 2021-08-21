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

namespace LoginSystemBKA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Dont keep the TextBoxes blank ...");
            }
            else
            {

                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='F:\C#\LoginSystemBKA\LoginSystemBKA\Databases\Data.mdf';Integrated Security=True;Connect Timeout=30;");
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Table where Username='" + textBox1.Text + "' and Password ='" + textBox2.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {

                        this.Hide();
                        Main ss = new Main();
                        ss.Show();


                    }
                    else
                    {
                        MessageBox.Show("Please check the Username and Password and Retry ....");
                    }

                }
                catch
                {

                    MessageBox.Show("Database Connectivity Error ...");

                }

            }    

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help ss = new Help();
            ss.Show();
        }

        private void PwordLb_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp ss = new SignUp();
            ss.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
