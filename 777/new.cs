﻿using System;
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
        SqlConnection cnn = new SqlConnection(@"Data Source=ASUS\SQLEXPRESS;Initial Catalog=hh;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter dr = new SqlDataAdapter();
        DataSet d1 = new DataSet();
        DataSet d2 = new DataSet();
        DataSet d3 = new DataSet();
        DataSet d4 = new DataSet();
        BindingSource bind = new BindingSource();
        public @new()
        {
            InitializeComponent();
        }

        private void @new_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String st;
            st = textBox1.Text.ToString();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Вы не заполнили поле, попробуйте еще раз!");
            }
            else
            {
                try
                {
                    da = new SqlDataAdapter(st, cnn);
                    da.Fill(d1, "Vacancy");
                    bind.DataSource = d1.Tables["Vacancy"];
                    da = new SqlDataAdapter(st, cnn);
                    dataGridView1.DataSource = bind;
                }
                catch (Exception)
                {
                    MessageBox.Show("Возможно, в запросе есть ошибка, попробуйте еще раз!");// обработка
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d1 = new DataSet();
            dataGridView1.Columns.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
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
            chart1.BackColor = Color.Gray;
            chart1.BackSecondaryColor = Color.WhiteSmoke;
            chart1.BackGradientStyle = GradientStyle.DiagonalRight;

            chart1.BorderlineDashStyle = ChartDashStyle.Solid;
            chart1.BorderlineColor = Color.Gray;
            chart1.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;

            // Форматировать область диаграммы
            chart1.ChartAreas[0].BackColor = Color.Wheat;

            if (radioButton1.Checked == true)
            {
                chart1.Series.Add(new Series(" "+ s2)
                {
                    ChartType = SeriesChartType.Column
                });
            }
            else if (radioButton2.Checked == true)
            {
                chart1.Series.Add(new Series("ColumnSeries")
                {
                    ChartType = SeriesChartType.Pie
                });
            }
            else if (radioButton3.Checked == true)
            {
                chart1.Series.Add(new Series(" "+s2)
                {
                    ChartType = SeriesChartType.Line
                });
            }
            else { 
                MessageBox.Show("Выберете тип диаграммы!");
            }

            if ((textBox2.Text == "")||(textBox3.Text==""))
            {
                MessageBox.Show("Вы не заполнили поле, попробуйте еще раз!");
            }
            else
            {
                try
                {
                    // Salary series data
                    chart1.Series[0].Points.DataBind(bind, s1, s2, null);

                    chart1.ChartAreas[0].Area3DStyle.Enable3D = true;

                }
                catch (Exception)
                {
                    MessageBox.Show("Возможно, в запросе есть ошибка, попробуйте еще раз!");// обработка
                }
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}