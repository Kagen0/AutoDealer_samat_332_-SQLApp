using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDealer_samat_332
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        Point lastPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;

                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;

                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void LoadData()
        {

            DB db = new DB();

            MySqlConnection myConnection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=car_shop");
            myConnection.Open();
            string query = "SELECT * FROM `cars` ORDER BY `id`";
            MySqlCommand cmd = new MySqlCommand(query, myConnection);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;


            dataGridView1.Columns[0].Width = 235;
            dataGridView1.Columns[1].Width = 210;
            dataGridView1.Columns[2].Width = 210;
            dataGridView1.Columns[3].Width = 230;
            dataGridView1.Columns[4].Width = 230;

            dataGridView1.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold);
           

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "ID Производителя";
            dataGridView1.Columns[2].HeaderText = "Модель";
            dataGridView1.Columns[3].HeaderText = "Год выпуска";
            dataGridView1.Columns[4].HeaderText = "Цена (Рубли)";



            MySqlConnection myConnection1 = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=car_shop");
            myConnection1.Open();
            string query1 = "SELECT * FROM `receipts` ORDER BY `id`";
            MySqlCommand cmd1 = new MySqlCommand(query1, myConnection1);
            MySqlDataReader reader1 = cmd1.ExecuteReader();
            DataTable table1 = new DataTable();
            table1.Load(reader1);
            dataGridView2.DataSource = table1;


            dataGridView2.Columns[0].Width = 280;
            dataGridView2.Columns[1].Width = 280;
            dataGridView2.Columns[2].Width = 280;
            dataGridView2.Columns[3].Width = 280;
        

            dataGridView2.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView2.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold);


            dataGridView2.Columns[0].HeaderText = "ID";
            dataGridView2.Columns[1].HeaderText = "ID Машины";
            dataGridView2.Columns[2].HeaderText = "Водителей пригнавших машину";
            dataGridView2.Columns[3].HeaderText = "Номер телефона";



            MySqlConnection myConnection2 = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=car_shop");
            myConnection2.Open();
            string query2 = "SELECT * FROM `manufacturers` ORDER BY `id`";
            MySqlCommand cmd2 = new MySqlCommand(query2, myConnection2);
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            DataTable table2 = new DataTable();
            table2.Load(reader2);
            dataGridView3.DataSource = table2;


            dataGridView3.Columns[0].Width = 295;
            dataGridView3.Columns[1].Width = 420;
            dataGridView3.Columns[2].Width = 420;
            


            dataGridView3.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView3.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold);


            dataGridView3.Columns[0].HeaderText = "ID";
            dataGridView3.Columns[1].HeaderText = "Марка машины";
            dataGridView3.Columns[2].HeaderText = "Страна производитель";
          


            MySqlConnection myConnection3 = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=car_shop");
            myConnection3.Open();
            string query3 = "SELECT * FROM `drivers` ORDER BY `id`";
            MySqlCommand cmd3 = new MySqlCommand(query3, myConnection3);
            MySqlDataReader reader3 = cmd3.ExecuteReader();
            DataTable table3 = new DataTable();
            table3.Load(reader3);
            dataGridView4.DataSource = table3;


            dataGridView4.Columns[0].Width = 285;
            dataGridView4.Columns[1].Width = 280;
            dataGridView4.Columns[2].Width = 280;
            dataGridView4.Columns[3].Width = 280;


            dataGridView4.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView4.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView4.EnableHeadersVisualStyles = false;
            dataGridView4.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView4.ColumnHeadersDefaultCellStyle.Font.FontFamily, 10f, FontStyle.Bold);


            dataGridView4.Columns[0].HeaderText = "ID";
            dataGridView4.Columns[1].HeaderText = "Имя";
            dataGridView4.Columns[2].HeaderText = "Фамилия";
            dataGridView4.Columns[3].HeaderText = "Номер телефона";

            myConnection.Close();

          
        }

        private void closeButton_MouseDown(object sender, MouseEventArgs e)
        {
            closeButton.ForeColor = Color.Maroon;
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.CornflowerBlue;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Silver;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
