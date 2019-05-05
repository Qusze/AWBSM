using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AWBSM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Get_Table("Маршрут", 1); // заполняем таблицу "Маршрут"
            Get_Table("Билет", 2);   // заполняем таблицу "Билет"
            Get_Table("Водитель", 3);
            Get_Table("Автобус", 4);
            Get_Table("Диспетчер", 5);
            textBox1.Text = "0";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
        private void Get_Table(string table_name, int num_dG)
        {
            Form1 f1 = new Form1();
            string CommandText = "SELECT * FROM ";
            CommandText += table_name;
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, f1.ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, table_name);
            if (num_dG == 1) dataGridView1.DataSource = ds.Tables[table_name].DefaultView;
            if (num_dG == 2) dataGridView2.DataSource = ds.Tables[table_name].DefaultView;
            if (num_dG == 3) dataGridView3.DataSource = ds.Tables[table_name].DefaultView;
            if (num_dG == 4) dataGridView4.DataSource = ds.Tables[table_name].DefaultView;
            if (num_dG == 5) dataGridView5.DataSource = ds.Tables[table_name].DefaultView;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
