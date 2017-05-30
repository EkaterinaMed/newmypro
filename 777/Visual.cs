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
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace _777
{
    public partial class @new : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=hh;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter dr = new SqlDataAdapter();
        DataSet d1 = new DataSet();
        BindingSource bind = new BindingSource();
        public @new()
        {
            InitializeComponent();
        }

        private void @new_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)//обработка подстказки
        {
            this.toolTip1.SetToolTip(this.textBox1, "Введите названия столбцов таким образом: Имя_таблицы.Столбец или count(Имя_таблицы.Столбец) as 'Количество'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String st, s1, f;//создание строк
            st = textBox1.Text.ToString();//объявление строк
            f = textBox4.Text.ToString();
            string[] s = st.Split(char.Parse(","));//разбиение строки на массив, разделитель ","
            if (textBox1.Text == "")//если пустой
            {
                DialogResult result = MessageBox.Show("Вы не заполнили поле, попробуйте еще раз!", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);// обработка ошибки
            }
            else
            {
                if (textBox4.Text == "")//если поле для фильтра пустое
                {
                    if ((st.StartsWith("count")) || (st.StartsWith("max")) || (st.StartsWith("min")) || (st.StartsWith("sum")) || (st.StartsWith("avg")))//если строка начинается с count...
                    {
                        s1 = "Select distinct " + st + " from Experience,Currency,Company,Conditions,Expectations,Location,Metro_station,Name_vacancy,Query,Query_name,Query_vacancy,Requerments,Salary, Vac_con,Vac_exp,Vac_req,Vacancy,City where City.id_city = Location.id_city and Metro_station.id_metro_station=Location.id_metro_station and Vacancy.id_location=Location.id_location and Experience.id_experience=Vacancy.id_experience and Currency.id_currency=Salary.id_currency and Salary.id_salary=Vacancy.id_salary and Name_vacancy.id_name_vacancy=Vacancy.id_name_vacancy and Query_name.id_query_name=Query.id_query_name and Query.id_query=Query_vacancy.id_query and Query_vacancy.id_vacancy=Vacancy.id_vacancy and  Company.id_company =Vacancy.id_company and Requerments.id_requerment=Vac_req.id_requerment and Vacancy.id_vacancy=Vac_req.id_vacancy and Conditions.id_condition=Vac_con.id_condition and Vacancy.id_vacancy=Vac_con.id_vacancy and Expectations.id_expectation=Vac_exp.id_expectation and Vacancy.id_vacancy=Vac_exp.id_vacancy ";
                    }
                    else
                        s1 = "Select distinct " + st + " from Experience,Currency,Company,Conditions,Expectations,Location,Metro_station,Name_vacancy,Query,Query_name,Query_vacancy,Requerments,Salary, Vac_con,Vac_exp,Vac_req,Vacancy,City where City.id_city = Location.id_city and Metro_station.id_metro_station=Location.id_metro_station and Vacancy.id_location=Location.id_location and Experience.id_experience=Vacancy.id_experience and Currency.id_currency=Salary.id_currency and Salary.id_salary=Vacancy.id_salary and Name_vacancy.id_name_vacancy=Vacancy.id_name_vacancy and Query_name.id_query_name=Query.id_query_name and Query.id_query=Query_vacancy.id_query and Query_vacancy.id_vacancy=Vacancy.id_vacancy and  Company.id_company =Vacancy.id_company and Requerments.id_requerment=Vac_req.id_requerment and Vacancy.id_vacancy=Vac_req.id_vacancy and Conditions.id_condition=Vac_con.id_condition and Vacancy.id_vacancy=Vac_con.id_vacancy and Expectations.id_expectation=Vac_exp.id_expectation and Vacancy.id_vacancy=Vac_exp.id_vacancy group by " + s[0];
                    try
                    {
                        da = new SqlDataAdapter(s1, cnn);//вывод результата
                        da.Fill(d1, "Vacancy");
                        bind.DataSource = d1.Tables["Vacancy"];
                        da = new SqlDataAdapter(s1, cnn);
                        dataGridView1.DataSource = bind;
                    }
                    catch (Exception)
                    {
                        DialogResult result = MessageBox.Show("Возможно в запросе есть ошибка, попробуйте еще раз!", "Ошибка", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);// обработка ошибки
                    }

                }
                else {
                    if ((st.StartsWith("count")) || (st.StartsWith("max")) || (st.StartsWith("min")) || (st.StartsWith("sum")) || (st.StartsWith("avg"))) //если начинается со слов count...
                    {
                        s1 = "Select distinct " + st + " from Experience,Currency,Company,Conditions,Expectations,Location,Metro_station,Name_vacancy,Query,Query_name,Query_vacancy,Requerments,Salary, Vac_con,Vac_exp,Vac_req,Vacancy,City where City.id_city = Location.id_city and Metro_station.id_metro_station=Location.id_metro_station and Vacancy.id_location=Location.id_location and Experience.id_experience=Vacancy.id_experience and Currency.id_currency=Salary.id_currency and Salary.id_salary=Vacancy.id_salary and Name_vacancy.id_name_vacancy=Vacancy.id_name_vacancy and Query_name.id_query_name=Query.id_query_name and Query.id_query=Query_vacancy.id_query and Query_vacancy.id_vacancy=Vacancy.id_vacancy and  Company.id_company =Vacancy.id_company and Requerments.id_requerment=Vac_req.id_requerment and Vacancy.id_vacancy=Vac_req.id_vacancy and Conditions.id_condition=Vac_con.id_condition and Vacancy.id_vacancy=Vac_con.id_vacancy and Expectations.id_expectation=Vac_exp.id_expectation and Vacancy.id_vacancy=Vac_exp.id_vacancy and " + f;
                    }
                    else if (!((s[1].StartsWith("count")) || (s[1].StartsWith("max")) || (s[1].StartsWith("min")) || (s[1].StartsWith("sum")) || (s[1].StartsWith("avg"))))//если не начинается со слов count...
                    {
                        s1 = "Select distinct " + st + " from Experience,Currency,Company,Conditions,Expectations,Location,Metro_station,Name_vacancy,Query,Query_name,Query_vacancy,Requerments,Salary, Vac_con,Vac_exp,Vac_req,Vacancy,City where City.id_city = Location.id_city and Metro_station.id_metro_station=Location.id_metro_station and Vacancy.id_location=Location.id_location and Experience.id_experience=Vacancy.id_experience and Currency.id_currency=Salary.id_currency and Salary.id_salary=Vacancy.id_salary and Name_vacancy.id_name_vacancy=Vacancy.id_name_vacancy and Query_name.id_query_name=Query.id_query_name and Query.id_query=Query_vacancy.id_query and Query_vacancy.id_vacancy=Vacancy.id_vacancy and  Company.id_company =Vacancy.id_company and Requerments.id_requerment=Vac_req.id_requerment and Vacancy.id_vacancy=Vac_req.id_vacancy and Conditions.id_condition=Vac_con.id_condition and Vacancy.id_vacancy=Vac_con.id_vacancy and Expectations.id_expectation=Vac_exp.id_expectation and Vacancy.id_vacancy=Vac_exp.id_vacancy group by " + s[0] +" , "+ s[1];
                    }
                    else
                        s1 = "Select distinct " + st + " from Experience,Currency,Company,Conditions,Expectations,Location,Metro_station,Name_vacancy,Query,Query_name,Query_vacancy,Requerments,Salary, Vac_con,Vac_exp,Vac_req,Vacancy,City where City.id_city = Location.id_city and Metro_station.id_metro_station=Location.id_metro_station and Vacancy.id_location=Location.id_location and Experience.id_experience=Vacancy.id_experience and Currency.id_currency=Salary.id_currency and Salary.id_salary=Vacancy.id_salary and Name_vacancy.id_name_vacancy=Vacancy.id_name_vacancy and Query_name.id_query_name=Query.id_query_name and Query.id_query=Query_vacancy.id_query and Query_vacancy.id_vacancy=Vacancy.id_vacancy and  Company.id_company =Vacancy.id_company and Requerments.id_requerment=Vac_req.id_requerment and Vacancy.id_vacancy=Vac_req.id_vacancy and Conditions.id_condition=Vac_con.id_condition and Vacancy.id_vacancy=Vac_con.id_vacancy and Expectations.id_expectation=Vac_exp.id_expectation and Vacancy.id_vacancy=Vac_exp.id_vacancy and " + f + " group by " + s[0];
                    try
                    {
                        da = new SqlDataAdapter(s1, cnn);//выполнение запроса
                        da.Fill(d1, "Vacancy");
                        bind.DataSource = d1.Tables["Vacancy"];
                        da = new SqlDataAdapter(s1, cnn);
                        dataGridView1.DataSource = bind;
                   }
                    catch (Exception)
                    {
                        DialogResult result = MessageBox.Show("Возможно в запросе есть ошибка, попробуйте еще раз!", "Ошибка", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);// обработка ошибки
                    }
                }
            }
        }
    
        

        private void button2_Click(object sender, EventArgs e)
        {
            d1 = new DataSet();//отчистки всех полей
            dataGridView1.Columns.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            chart1.Series.Clear();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String st, s1, s2;
            st = textBox1.Text.ToString();
            dr = new SqlDataAdapter(st, cnn);
            s1 = textBox2.Text.ToString();
            s2 = textBox3.Text.ToString();

            chart1.Series.Clear();
            // Форматировать диаграмму
            chart1.BackColor = Color.Gray;//цвет фона
            chart1.BackSecondaryColor = Color.WhiteSmoke;//цвет рамки
            chart1.BackGradientStyle = GradientStyle.DiagonalRight;//градиент

            chart1.BorderlineDashStyle = ChartDashStyle.Solid;
            chart1.BorderlineColor = Color.Gray;
            chart1.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;

            // Форматировать область диаграммы
            chart1.ChartAreas[0].BackColor = Color.Wheat;

            if (radioButton1.Checked == true)//если включен
            {
                chart1.Series.Add(new Series(" "+ s2)
                {
                    ChartType = SeriesChartType.Column//тип диаграммы столбчатая
                });
            }
            else if (radioButton2.Checked == true)
            {
                chart1.Series.Add(new Series("ColumnSeries")
                {
                    ChartType = SeriesChartType.Pie//тип диаграммы круговая
                });
            }
            else if (radioButton3.Checked == true)
            {
                chart1.Series.Add(new Series(" "+s2)
                {
                    ChartType = SeriesChartType.Line//тип диаграммы график
                });
            }
            else {
                DialogResult result = MessageBox.Show("Выберете тип диаграммы!", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);// обработка ошибки
            }

            if ((textBox2.Text == "")||(textBox3.Text==""))
            {
                DialogResult result = MessageBox.Show("Вы не заполнили поле, попробуйте еще раз!", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);// обработка ошибки
            }
            else
            {
                try
                {
                    chart1.Series[0].Points.DataBind(bind, s1, s2, null);

                    chart1.ChartAreas[0].Area3DStyle.Enable3D = true;

                }
                catch (Exception)
                {
                    DialogResult result = MessageBox.Show("Возможно в запросе есть ошибка, попробуйте еще раз!", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);// обработка ошибки
                }
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.textBox4, "Введите фильтр для таблицы, например, text_experience='не требуется'");//объявление подсказки
        }
    }
}
