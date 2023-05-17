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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursach_zadumin
{
    public partial class DobKLIENT : Form
    {
        database database =new database();
        public DobKLIENT()
        {
            InitializeComponent();
        }

        private void DobKLIENT_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kurs1DataSet11.Klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter1.Fill(this.kurs1DataSet11.Klient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kurs1DataSet.sport_inv". При необходимости она может быть перемещена или удалена.

            // TODO: данная строка кода позволяет загрузить данные в таблицу "kurs1DataSet.Klient". При необходимости она может быть перемещена или удалена.

            // TODO: данная строка кода позволяет загрузить данные в таблицу "kurs1DataSet1.sport_inv". При необходимости она может быть перемещена или удалена.
            this.sport_invTableAdapter.Fill(this.kurs1DataSet1.sport_inv);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var id = textBox1.Text;
            var name = textBox2.Text;
            var sarenda = dateTimePicker1.Value;
          
            var iNVENTAR = comboBox1.Text;
            
          



            var a = $"insert into Klient (id,name,time,Thing) values('{id}','{name}','{sarenda}','{iNVENTAR}')";

            var command = new SqlCommand(a, database.GetSqlConnection());

            command.ExecuteNonQuery();
        }
    }
}
