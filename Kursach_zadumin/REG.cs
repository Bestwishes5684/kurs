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
using System.Drawing.Text;

namespace Kursach_zadumin
{
    
    public partial class REG : Form
    {
        database database=new database();   
        public REG()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var password = textBox2.Text;

            string query = $"insert into register(login_user,password_user) values('{login}','{password}')";
           
            SqlCommand command = new SqlCommand(query, database.GetSqlConnection());
         
            database.openConnection();
            
            if (command.ExecuteNonQuery() == 1)
            {
                
                MessageBox.Show("Вы успешно создали аккаунт");
                Login login1 = new Login();
                this.Hide();
                login1.ShowDialog();

            }
            else
            {
                MessageBox.Show("Ошибка, не допустимый логин или пароль");
            }
         


            database.CloseConnection();
            

            

        }

        


        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var password = textBox2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"select id_user, login_user, password_user from register where login_user = '{login}' and password_user='{password}'";
            SqlCommand command = new SqlCommand(query, database.GetSqlConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("есть такой польователь придумайте другой логин ");
                button1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Такого пользователя нет");
                button1.Enabled = true;
            }
           

        }
    }
}
