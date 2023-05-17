using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel= Microsoft.Office.Interop.Excel;

namespace Kursach_zadumin
{
    public partial class Osnv : Form
    {
        database database=new database();

        public Osnv()
        {
            InitializeComponent();
        }

        private void Osnv_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kurs1DataSet.sport_inv". При необходимости она может быть перемещена или удалена.
            this.sport_invTableAdapter1.Fill(this.kurs1DataSet.sport_inv);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dobinv dobinv = new Dobinv();
            dobinv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            var rows = dataGridView1.SelectedRows;
            dataGridView1.CurrentCell = null;
            foreach (DataGridViewRow r in rows)
                r.Visible = false;
            string sure = "Вы уверенны?";
            string title = "Привет ";

           var result=MessageBox.Show(sure,title,MessageBoxButtons.YesNo,MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {

            
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() != string.Empty)
            {


                this.sport_invTableAdapter1.Delete((int)dataGridView1.Rows[index].Cells[0].Value, (string)dataGridView1.Rows[index].Cells[1].Value, (int)dataGridView1.Rows[index].Cells[2].Value, (string)dataGridView1.Rows[index].Cells[3].Value, (int)dataGridView1.Rows[index].Cells[4].Value);

            }
            }
            
    }

        private void button3_Click(object sender, EventArgs e)
        {
            

            int i, j;
           
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            ExcelApp.Cells[1, 1] = "id";
            ExcelApp.Cells[1, 2] = "Код машины";
            ExcelApp.Cells[1, 3] = "ФИО покупателя";
            ExcelApp.Cells[1, 4] = "Телефон покупателя";
            ExcelApp.Cells[1, 5] = "Дата";
            ExcelApp.Cells[1, 6] = "Сумма";

            for ( i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for ( j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Klient klient = new Klient();
            klient.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null && dataGridView1.Rows[i].Cells[j].Value.ToString() == textBox1.Text)
                    {
                        dataGridView1.Rows[i].Cells[j].Selected = true;
                    }
                }
            }
          
               
                   
        }

        private void ReadSingleRow(DataGridView dataGrid,IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetString(3), record.GetInt32(4));
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
