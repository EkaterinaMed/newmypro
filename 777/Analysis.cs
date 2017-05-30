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
    public partial class Analysis : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=ASUS\SQLEXPRESS;Initial Catalog=hh;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet d1 = new DataSet();
        DataSet d2 = new DataSet();
        DataSet d3 = new DataSet();
        DataSet d4 = new DataSet();
        DataSet d5 = new DataSet();
        BindingSource bind = new BindingSource();
        public Analysis()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Количество вакансий и компаний", "Максимальная зарплата по станциям метро", "Количество вакансий по станциям метро",
            "Значение зарплаты по вакансиям, находящихся на м.Чернышевская","Количество вакансий по опыту работы" });//заполнение combobox

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Количество вакансий и компаний"://если вызвали, то выполняем запрос
                    da = new SqlDataAdapter("select count(distinct Company.name_company) as 'Количество компаний', COUNT(distinct Name_vacancy.name_vacancy) as 'Количество вакансий', date_vacancy as 'Дата' from Company,Vacancy,Name_vacancy,Query_vacancy,Query,Query_name where Vacancy.id_company=Company.id_company and Vacancy.id_name_vacancy=Name_vacancy.id_name_vacancy and Vacancy.id_vacancy=Query_vacancy.id_vacancy and Query_vacancy.id_query=Query.id_query and Query_name.id_query_name=Query.id_query_name and Query_name.name_query='\"IT\"' group by date_vacancy", cnn);
                    da.Fill(d1, "Vacancy");
                    bind.DataSource = d1.Tables["Vacancy"];
                    da = new SqlDataAdapter("select count(distinct Company.name_company) as 'Количество компаний', COUNT(distinct Name_vacancy.name_vacancy) as 'Количество вакансий', date_vacancy as 'Дата' from Company,Vacancy,Name_vacancy,Query_vacancy,Query,Query_name where Vacancy.id_company=Company.id_company and Vacancy.id_name_vacancy=Name_vacancy.id_name_vacancy and Vacancy.id_vacancy=Query_vacancy.id_vacancy and Query_vacancy.id_query=Query.id_query and Query_name.id_query_name=Query.id_query_name and Query_name.name_query='\"IT\"' group by date_vacancy", cnn);
                    dataGridView1.DataSource = bind;
                    break;
                case "Максимальная зарплата по станциям метро"://если вызвали, то выполняем запрос
                    da = new SqlDataAdapter("select distinct name_metro_station as 'Название метро', max(Salary.salary) as 'Максимальная зарплата' from Metro_station, Salary,Location,Vacancy,Query,Query_name,Query_vacancy where Metro_station.id_metro_station=Location.id_metro_station and Location.id_location=Vacancy.id_location and Vacancy.id_salary=Salary.id_salary and Vacancy.id_vacancy=Query_vacancy.id_vacancy and Query_vacancy.id_query=Query.id_query and Query.id_query_name=Query_name.id_query_name and name_query='\"IT\"' group by name_metro_station", cnn);
                    da.Fill(d2, "Vacancy");
                    bind.DataSource = d2.Tables["Vacancy"];
                    da = new SqlDataAdapter("select distinct name_metro_station as 'Название метро', max(Salary.salary) as 'Максимальная зарплата' from Metro_station, Salary,Location,Vacancy,Query,Query_name,Query_vacancy where Metro_station.id_metro_station=Location.id_metro_station and Location.id_location=Vacancy.id_location and Vacancy.id_salary=Salary.id_salary and Vacancy.id_vacancy=Query_vacancy.id_vacancy and Query_vacancy.id_query=Query.id_query and Query.id_query_name=Query_name.id_query_name and name_query='\"IT\"' group by name_metro_station", cnn);
                    dataGridView1.DataSource = bind;
                    break;
                case "Количество вакансий по станциям метро"://если вызвали, то выполняем запрос
                    da = new SqlDataAdapter("select distinct name_metro_station as 'Название метро',count(distinct Name_vacancy.id_name_vacancy) as 'Количество вакансий 'from Metro_station,Name_vacancy,Vacancy,Location,Query_vacancy,Query_name,Query where Query_vacancy.id_vacancy=Vacancy.id_vacancy and Query_name.id_query_name=Query.id_query_name and Query.id_query=Query_vacancy.id_query and name_query='\"IT\"' and Vacancy.id_name_vacancy=Name_vacancy.id_name_vacancy and Vacancy.id_location=Location.id_location and Location.id_metro_station=Metro_station.id_metro_station group by Metro_station.name_metro_station", cnn);
                    da.Fill(d3, "Vacancy");
                    bind.DataSource = d3.Tables["Vacancy"];
                    da = new SqlDataAdapter("select distinct name_metro_station as 'Название метро',count(distinct Name_vacancy.id_name_vacancy) as 'Количество вакансий 'from Metro_station,Name_vacancy,Vacancy,Location,Query_vacancy,Query_name,Query where Query_vacancy.id_vacancy=Vacancy.id_vacancy and Query_name.id_query_name=Query.id_query_name and Query.id_query=Query_vacancy.id_query and name_query='\"IT\"' and Vacancy.id_name_vacancy=Name_vacancy.id_name_vacancy and Vacancy.id_location=Location.id_location and Location.id_metro_station=Metro_station.id_metro_station group by Metro_station.name_metro_station", cnn);
                    dataGridView1.DataSource = bind;
                    break;
                case "Значение зарплаты по вакансиям, находящихся на м.Чернышевская"://если вызвали, то выполняем запрос
                    da = new SqlDataAdapter("select distinct Name_vacancy.name_vacancy as 'Название вакансии', Salary.salary 'Значение зарплаты' from Name_vacancy,Salary,Vacancy,Location,Metro_station,Query_vacancy,Query_name,Query where Query_vacancy.id_vacancy=Vacancy.id_vacancy and Query_name.id_query_name=Query.id_query_name and Query.id_query=Query_vacancy.id_query and name_query='\"IT\"' and Vacancy.id_name_vacancy=Name_vacancy.id_name_vacancy and Vacancy.id_salary=Salary.id_salary and Location.id_location=Vacancy.id_location and Location.id_metro_station=Metro_station.id_metro_station and Metro_station.name_metro_station=' Чернышевская'", cnn);
                    da.Fill(d4, "Vacancy");
                    bind.DataSource = d4.Tables["Vacancy"];
                    da = new SqlDataAdapter("select distinct Name_vacancy.name_vacancy as 'Название вакансии', Salary.salary 'Значение зарплаты' from Name_vacancy,Salary,Vacancy,Location,Metro_station,Query_vacancy,Query_name,Query where Query_vacancy.id_vacancy=Vacancy.id_vacancy and Query_name.id_query_name=Query.id_query_name and Query.id_query=Query_vacancy.id_query and name_query='\"IT\"' and Vacancy.id_name_vacancy=Name_vacancy.id_name_vacancy and Vacancy.id_salary=Salary.id_salary and Location.id_location=Vacancy.id_location and Location.id_metro_station=Metro_station.id_metro_station and Metro_station.name_metro_station=' Чернышевская'", cnn);
                    dataGridView1.DataSource = bind;
                    break;
                case "Количество вакансий по опыту работы"://если вызвали, то выполняем запрос
                    da = new SqlDataAdapter("select distinct Experience.text_experience as 'Опыт', count(distinct Name_vacancy.id_name_vacancy) as 'Количество вакансий' from Experience,Name_vacancy,Vacancy,Query_vacancy,Query_name,Query where Query_vacancy.id_vacancy=Vacancy.id_vacancy and Query_name.id_query_name=Query.id_query_name and Query.id_query=Query_vacancy.id_query and name_query='\"IT\"' and Experience.id_experience=Vacancy.id_experience and Vacancy.id_name_vacancy=Name_vacancy.id_name_vacancy group by Experience.text_experience", cnn);
                    da.Fill(d5, "Vacancy");
                    bind.DataSource = d5.Tables["Vacancy"];
                    da = new SqlDataAdapter("select distinct Experience.text_experience as 'Опыт', count(distinct Name_vacancy.id_name_vacancy) as 'Количество вакансий' from Experience,Name_vacancy,Vacancy,Query_vacancy,Query_name,Query where Query_vacancy.id_vacancy=Vacancy.id_vacancy and Query_name.id_query_name=Query.id_query_name and Query.id_query=Query_vacancy.id_query and name_query='\"IT\"' and Experience.id_experience=Vacancy.id_experience and Vacancy.id_name_vacancy=Name_vacancy.id_name_vacancy group by Experience.text_experience", cnn);
                    dataGridView1.DataSource = bind;
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            switch (comboBox1.Text)
            {
                case "Количество вакансий и компаний"://если вызвали, то запускаем новый процесс,открываем MS POWER BI
                    try
                    {
                        Process.Start(@"C:\Users\dns\Desktop\777\1.pbix");
                    }
                    catch (Exception)
                    {
                        DialogResult result = MessageBox.Show("Невозможно открыть файл!","Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);// обработка ошибки

                    }
                    break;
                case "Максимальная зарплата по станциям метро"://если вызвали, то запускаем новый процесс,открываем MS POWER BI
                    try {
                        Process.Start(@"C:\Users\dns\Desktop\777\2.pbix");
                    }
                    catch (Exception)
                    {
                        DialogResult result = MessageBox.Show("Невозможно открыть файл!", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);// обработка ошибки
                    }
                    break;
                case "Количество вакансий по станциям метро"://если вызвали, то запускаем новый процесс,открываем MS POWER BI
                    try {
                        Process.Start(@"C:\Users\dns\Desktop\777\3.pbix");
                    }
                    catch (Exception)
                    {
                        DialogResult result = MessageBox.Show("Невозможно открыть файл!", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);// обработка ошибки
                    }
                    break;
                case "Значение зарплаты по вакансиям, находящихся на м.Чернышевская"://если вызвали, то запускаем новый процесс,открываем MS POWER BI
                    try {
                        Process.Start(@"C:\Users\dns\Desktop\777\4.pbix");
                    }
                    catch (Exception)
                    {
                        DialogResult result = MessageBox.Show("Невозможно открыть файл!", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);// обработка ошибки
                    }
                    break;
                case "Количество вакансий по опыту работы"://если вызвали, то запускаем новый процесс,открываем MS POWER BI
                    try {
                        Process.Start(@"C:\Users\dns\Desktop\777\5.pbix");
                    }
                    catch (Exception)
                    {
                        DialogResult result = MessageBox.Show("Невозможно открыть файл!", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);// обработка ошибки
                    }
                    break;
                default:
                    DialogResult result1 = MessageBox.Show("Вы не выбрали название запроса! Попробуйте еще раз.", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);// обработка ошибки
                    break;
            }
        }

        }
}
