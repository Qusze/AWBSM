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
using System.Data.Odbc;
namespace AWBSM
{
    public partial class Form1 : Form
    {   

        public string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" +
              "Data Source = C:\\Users\\alepo\\source\\repos\\AWBSM\\AWBSM\\DBAWB.mdb";

        private int act_table = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void билетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void водителыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CommandText = "SELECT " +
            "[Перевозка].[Номер], " +
            "[Маршрут].[Номер маршрута], " +
            "[Маршрут].[Пункт назначения], " +
            "[Маршрут].[Время отправки], " +
            "[Маршрут].[Время прибытия], " +
            "[Билет].[Место], " +
            "[Билет].[Ф_И_О], " +
            "[Билет].[Стоимость], " +
            "[Водитель].[Ф_И_О] " +
            "FROM " +
            "[Перевозка], " +
            "[Маршрут], " +
            "[Билет], " +
            "[Водитель] " +
            "WHERE " +
            "([Перевозка].[ID_Marshrut]=[Маршрут].[ID_Marshrut]) AND " +
            "([Перевозка].[ID_Bilet] = [Билет].[ID_Bilet]) AND " +
            "([Перевозка].[ID_Voditel] = [Водитель].[ID_Voditel]) ";

            if (textBox1.Text != "")  // если набран текст в поле фильтра
            {
                if (comboBox1.SelectedIndex == 0) // № перевозки
                    CommandText = CommandText + " AND ([Перевозка].[Номер] = '" + textBox1.Text + "')";
                if (comboBox1.SelectedIndex == 1) // № маршрута
                    CommandText = CommandText + " AND (Маршрут.[Номер маршрута] = '" + textBox1.Text + "') ";

                if (comboBox1.SelectedIndex == 2) // Пункт назначения
                    CommandText = CommandText + " AND (Маршрут.[Пункт назначения] LIKE '" + textBox1.Text + "%') ";
                if (comboBox1.SelectedIndex == 3) // Пассажир
                    CommandText = CommandText + " AND (Билет.[Ф_И_О] LIKE '" + textBox1.Text + "%') ";
                if (comboBox1.SelectedIndex == 4) // Водитель
                    CommandText = CommandText + " AND ([Водитель].[Ф_И_О] LIKE '" + textBox1.Text + "%') ";
            }

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds,"[Перевозка]");
            dataGridView1.DataSource = ds.Tables["[Перевозка]"].DefaultView;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }
    }
}
