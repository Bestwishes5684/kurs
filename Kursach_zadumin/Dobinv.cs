using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kursach_zadumin
{
    public partial class Dobinv : Form
    {
        database database = new database();
        public Dobinv()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var id = textBox1.Text;
            var name = textBox2.Text;
            var price=textBox3.Text;
            var vid=textBox4.Text;
            var kol=textBox5.Text;

            var a = $"insert into sport_inv (id,name,price,vid_sporta,[kol-vo]) values('{id}','{name}','{price}','{vid}','{kol}')";

            var command = new SqlCommand(a, database.GetSqlConnection());

            command.ExecuteNonQuery();

            
        }
    }
}
