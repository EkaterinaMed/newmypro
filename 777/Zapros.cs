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


namespace _777
{
    public partial class Zapros : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=ASUS\SQLEXPRESS;Initial Catalog=hh;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet d1 = new DataSet();
        DataSet d2 = new DataSet();
        BindingSource bind = new BindingSource();
        BindingSource bind1 = new BindingSource();
        public Zapros()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String st,s1;//создаем две строки
            st = textBox1.Text.ToString();
            string[] s = st.Split(char.Parse(","));//разбиваем на массив слов или словосочетаний, разделитель ","
            int K = s.Length; //считаем количество слов
            if (K==1){//если количество 1, то выполняем запрос
                s1 = "if exists (Select * from Name_vacancy,Vacancy, Query,Query_name,Query_vacancy where Name_vacancy.id_name_vacancy=Vacancy.id_name_vacancy and Query.id_query= Query_vacancy.id_query and Query_vacancy.id_vacancy=Vacancy.id_vacancy and Query_name.id_query_name = Query.id_query_name and Query_name.name_query ='" + st +
                "')" +
                "begin (Select distinct Name_vacancy.name_vacancy from Name_vacancy,Vacancy, Query,Query_name,Query_vacancy where Name_vacancy.id_name_vacancy=Vacancy.id_name_vacancy and Query.id_query= Query_vacancy.id_query and Query_vacancy.id_vacancy=Vacancy.id_vacancy and Query_name.id_query_name = Query.id_query_name  and Query_name.name_query ='" + st +
                "')end";
                StreamWriter SW = new StreamWriter(new FileStream(@"C:\Users\dns\Desktop\777\hhparser\FileName.txt", FileMode.Create, FileAccess.Write));//записываем строку в файл
                SW.Write(s[0]);
                SW.Close();
            }
            else if (K == 2){//если количество 2, то выполняем запрос
                s1 = "if exists (Select * from Name_vacancy,Vacancy, Query,Query_name,Query_vacancy where Name_vacancy.id_name_vacancy=Vacancy.id_name_vacancy and Query.id_query= Query_vacancy.id_query and Query_vacancy.id_vacancy=Vacancy.id_vacancy and Query_name.id_query_name = Query.id_query_name and ((Query_name.name_query ='" + s[0] +
                    "') or(Query_name.name_query='" + s[1] +
                    "')))begin (Select distinct Name_vacancy.name_vacancy from Name_vacancy,Vacancy, Query,Query_name,Query_vacancy where Name_vacancy.id_name_vacancy=Vacancy.id_name_vacancy and Query.id_query= Query_vacancy.id_query and Query_vacancy.id_vacancy=Vacancy.id_vacancy and Query_name.id_query_name = Query.id_query_name  and ((Query_name.name_query ='" + s[0] +
                    "') or(Query_name.name_query='" + s[1] + "'))) end";
                StreamWriter SW = new StreamWriter(new FileStream(@"C:\Users\dns\Desktop\777\hhparser\FileName.txt", FileMode.Create, FileAccess.Write));//записываем строку в файл
                SW.Write(s[0]+"+"+s[1]);
                SW.Close();
            }
            else if (K == 3)//если количество 3, то выполняем запрос
            {
                s1 = "if exists (Select * from Name_vacancy,Vacancy, Query,Query_name,Query_vacancy where Name_vacancy.id_name_vacancy=Vacancy.id_name_vacancy and Query.id_query= Query_vacancy.id_query and Query_vacancy.id_vacancy=Vacancy.id_vacancy and Query_name.id_query_name = Query.id_query_name and ((Query_name.name_query ='" + s[0] +
                "') or(Query_name.name_query='" + s[1] +
                "')or(Query_name.name_query='" + s[2] + "')))begin (Select distinct Name_vacancy.name_vacancy from Name_vacancy,Vacancy, Query,Query_name,Query_vacancy where Name_vacancy.id_name_vacancy=Vacancy.id_name_vacancy and Query.id_query= Query_vacancy.id_query and Query_vacancy.id_vacancy=Vacancy.id_vacancy and Query_name.id_query_name = Query.id_query_name  and ((Query_name.name_query ='" + s[0] +
                "') or(Query_name.name_query='" + s[1] + "')or(Query_name.name_query='" + s[2] + "'))) end";
                StreamWriter SW = new StreamWriter(new FileStream(@"C:\Users\dns\Desktop\777\hhparser\FileName.txt", FileMode.Create, FileAccess.Write));//записываем строку в файл
                SW.Write(s[0] +"+"+ s[1]+"+"+s[2]);
                SW.Close();
            }
            else//иначе строка=null
            {
                s1 = null;
            }

            if (textBox1.Text == "")//если textbox пустой
            {
                DialogResult result = MessageBox.Show("Вы не заполнили поле! Попробуйте еще раз.", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);// обработка ошибки
            }
            else
            {
                try
                {
                    da = new SqlDataAdapter(s1, cnn);//заполнение datagrid
                    da.Fill(d1, "Name_vacancy");
                    bind.DataSource = d1.Tables["Name_vacancy"];
                    da = new SqlDataAdapter(s1, cnn);
                    dataGridView1.DataSource = bind;
                    textBox2.DataBindings.Add("Text", bind, "name_vacancy");//связывание ячейки с textbox
                    richTextBox1.Clear();
                    
                    if (dataGridView1.Rows.Count == 0)
                    {
                        DialogResult result = MessageBox.Show("По Вашему запросу ничего не найдено! Попробуйте еще раз!", "Сообщение", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);// обработка ошибки
                    }
                }
                catch (Exception)
                {
                    DialogResult result = MessageBox.Show(
                        "Такого запроса в БД не нашлось. Загрузить новые данные в БД?",
                        "Сообщение", 
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);
                    if (result == DialogResult.Yes) {
                        try
                        {
                            Process.Start("C://Users//dns//Desktop//777//hhparser//hhparser.exe");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Невозможно открыть файл!");// обработка ошибки
                        }
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d1 = new DataSet();//отчистка всех полей
            dataGridView1.Columns.Clear();
            textBox1.Clear();
            textBox2.Clear();
            richTextBox1.Clear();
            textBox2.DataBindings.Clear();
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void Zapros_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=ASUS\SQLEXPRESS;Initial Catalog=hh;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("infa1", cnn);//вызов ХП
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 100);//объявление выходных параметров ХП
            cmd.Parameters["@name"].Value = Convert.ToString(textBox2.Text);
            cmd.Parameters.Add("@company", SqlDbType.VarChar, 100);
            cmd.Parameters["@company"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@salary", SqlDbType.VarChar, 20);
            cmd.Parameters["@salary"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@expirience", SqlDbType.VarChar, 1024);
            cmd.Parameters["@expirience"].Direction = ParameterDirection.Output;
            cnn.Open();
            cmd.ExecuteNonQuery();
            String n1,n2,n3;
            int k=0;
            n1 = "\nНАЗВАНИЕ КОМПАНИИ:";
            n2= "\nОПЫТ: ";
            n3 = "\nЗАРПЛАТА: ";

            String st, s1,s2,s3;
            st = textBox2.Text.ToString();
            s1 = "select distinct Requerments.text_requerment from Vacancy,Requerments,Name_vacancy,Vac_req where Vacancy.id_name_vacancy=Name_vacancy.id_name_vacancy and Requerments.id_requerment=Vac_req.id_requerment and Vac_req.id_vacancy=Vacancy.id_vacancy and Name_vacancy='" + st + "'order by text_requerment asc";
            s2 = "select distinct Expectations.text_expectation from Expectations,Vac_exp,Name_vacancy,Vacancy where Expectations.id_expectation=Vac_exp.id_expectation and Vac_exp.id_vacancy=Vacancy.id_vacancy and Vacancy.id_name_vacancy=Name_vacancy.id_name_vacancy and name_vacancy='" + st + "'order by text_expectation asc";
            s3 = "select distinct Conditions.text_condition from Conditions,Vac_con,Name_vacancy,Vacancy where Conditions.id_condition=Vac_con.id_condition and Vac_con.id_vacancy=Vacancy.id_vacancy and Vacancy.id_name_vacancy=Name_vacancy.id_name_vacancy and name_vacancy='"+st+"'order by text_condition asc";

            da = new SqlDataAdapter(s1, cnn);
            DataSet copyDataSet = d2.Copy();
            da.Fill(d2, "Name_vacancy");
            da = new SqlDataAdapter(s1, cnn);
            string filter = string.Format("text_requerment>='{0}'", textBox2.Text);//построение пользовательского фильтра
            DataRow[] row = d2.Tables[0].Select(filter, "text_requerment ");//выбор массива строк соответ фильтру
            if (row.Length == 0) //вывод массива найденных строк
            {
                richTextBox1.Text = "";
                k++;
            }
            else
                richTextBox1.Clear();
                
                richTextBox1.Text += "ТРЕБОВАНИЯ:\n";
                for (int i = 0; i < row.Length; i++)
                {
                    richTextBox1.Text +="o  "+ row[i]["text_requerment"] + "\n\n ";//вывод строк требований
                }
                d2.Clear();

                da = new SqlDataAdapter(s2, cnn);
                da.Fill(d2, "Name_vacancy");
                da = new SqlDataAdapter(s2, cnn);
                string filter1 = string.Format("text_expectation>='{0}'", textBox2.Text);
                DataRow[] row1 = d2.Tables[0].Select(filter1, "text_expectation");
                if (row1.Length == 0)
                {
                    richTextBox1.Text = "";
                    k++;
                }
                else
                    richTextBox1.Text += "ОБЯЗАННОСТИ:\n";
                for (int i = 0; i < row1.Length; i++)
                {
                    richTextBox1.Text +="o  "+ row1[i]["text_expectation"] + "\n\n ";//вывод строк обязанностей
                }
                d2.Clear();

                da = new SqlDataAdapter(s3, cnn);
                da.Fill(d2, "Name_vacancy");
                da = new SqlDataAdapter(s3, cnn);
                string filter2 = string.Format("text_condition>='{0}'", textBox2.Text);
                DataRow[] row2 = d2.Tables[0].Select(filter2, "text_condition");
                if (row2.Length == 0)
                {
                    richTextBox1.Text = "";
                    k++;
                }
                else
                    richTextBox1.Text += "УСЛОВИЯ:\n";
                for (int i = 0; i < row2.Length; i++)
                {
                    richTextBox1.Text += "o  "+ row2[i]["text_condition"] + "\n\n ";//вывод строк условий
                }
                if (k == 3)
                    richTextBox1.Clear();//если к=3, то отчистка richtextbox
                richTextBox1.Text += n1 + "\n" + cmd.Parameters["@company"].Value.ToString() + "\n" + n2 + "\n" + cmd.Parameters["@expirience"].Value.ToString() + "\n" + n3 + "\n" +
                   cmd.Parameters["@salary"].Value.ToString() + "\n";
                d2.Clear();
            cnn.Close();
        }
    }
}
