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
using System.Diagnostics;

namespace _777
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void поискДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zapros f = new Zapros();//вызов класс zapros
            f.Show();
        }

        private void анализСуществующихЗапросовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Analysis f = new Analysis();//вызов класс analysis
            f.Show();
        }

        private void соToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Program Files (x86)\Microsoft Power BI Desktop\bin\PBIDesktop.exe");//запуск нового процесса. Вызов MS POWER BI
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show("Невозможно открыть файл!", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);// обработка ошибки
            }
        }

        private void создатьВChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            @new f = new @new(); //вызов класса Visual
            f.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void вызватьСправкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            question f = new question();//вызов справки
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=ASUS\SQLEXPRESS;Initial Catalog=hh;Integrated Security=True");//проверка соединения
            try
            {
                cnn.Open();//если соединение открыто
                DialogResult result = MessageBox.Show("Соединение установлено!", "Сообщение", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);// обработка сообщения
                cnn.Close();
            }
            catch (Exception) //если нет
            {
                DialogResult result = MessageBox.Show("Ошибка соединения!", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);// обработка ошибки
            }
        }
    }
}
