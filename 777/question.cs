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

namespace _777
{
    public partial class question : Form
    {
        public question()
        {
            InitializeComponent();
        }

        private void question_Load(object sender, EventArgs e)
        {//добавление текста к справке
            label1.Text = "После запуска программы, открывается меню и перед пользователем\n стоит выбор: поиск данных, анализ данных, проверка соединения.\n\nНажав на «Поиск данных» возникает новое окно – окно поиска вакансий.\n В текстовое поле необходимо ввести запрос, например:\n «”ГУАП”,”Power BI”,”IT”», и нажать на кнопку «Найти вакансии».\n\nДалее в высветившимся списке вакансии выбрать одну, полную\n информацию о которой вы хотите найти.\n\nЧтобы ввести новый запрос, нужно нажать на кнопку «Отчистить поле»\n и ввести новые значения.";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
