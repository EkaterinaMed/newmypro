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
using System.IO;
using Microsoft.Win32;

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
            label3.Text = "Проверка на\nналичие \nMS Power BI";
            label2.Text = "Проверка на\nналичие\nSQL Server";
            label1.Text = "Проверка на\nсоединение\nк БД";
        }

        private void вызватьСправкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            question f = new question();//вызов справки
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=hh;Integrated Security=True");//проверка соединения
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

        private void button2_Click(object sender, EventArgs e)
        {
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        DialogResult result = MessageBox.Show("На этом компьютере доступны следующий SQL Server: " + Environment.MachineName + "\\" + instanceName, "Сообщение", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);// обработка ошибки
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Установите SQL Server", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);// обработка ошибки
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists("C://Program Files (x86)//Microsoft Power BI Desktop//bin//PBIDesktop.exe"))
            {
                DialogResult result = MessageBox.Show("MS Power BI доступен", "Сообщение", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);// обработка ошибки
            }
            else
            {
                DialogResult result = MessageBox.Show("Установите MS Power BI", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);// обработка ошибки
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
