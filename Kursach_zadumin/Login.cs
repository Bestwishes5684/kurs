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

namespace Kursach_zadumin
{
    public partial class Login : Form
    {
        database database = new database();
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   Login login = new Login();
            this.Hide();
            REG rEG = new REG();
            rEG.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var password = textBox2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"select id_user,login_user,password_user from register where  login_user='{login}'  and password_user='{password}'";
            SqlCommand command = new SqlCommand(query, database.GetSqlConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно авторизировались");
                
                Login login1 = new Login();
                Osnv osnv = new Osnv();
                this.Hide();
                osnv.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует");
            }
        }
    }
}

