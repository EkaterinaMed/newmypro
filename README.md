Разработан с целью анализа данных с сайта hh.ru 

Разработка производилась в операционной среде Windows. Работоспособность программы на UNIX-подобных ОС не проверялась. На данный момент программа умеет работать только с базами данных MSSQL Server, в дальнейшем список будет пополняться.

### Необходимые программы:

1. [MSSQL Server 2016 Express](https://www.microsoft.com/ru-ru/sql-server/sql-server-editions-express)
Необходим для создания БД.

2. [MS Power BI](https://powerbi.microsoft.com/ru-ru/downloads/)
Необходим для визуализации анализа данных.

3. [hhparser](https://github.com/GaPanda/hhparser)
С помощью этой программы происходит загрузка данных в БД

4. [Microsoft Visual Studio](https://www.visualstudio.com/ru/downloads/)

![default](https://cloud.githubusercontent.com/assets/28348635/25701820/b42c5f34-30d6-11e7-92c9-833e669acea3.png)

### Работа с SQL Server
1. Подключиться к серверу 

![1](https://cloud.githubusercontent.com/assets/28348635/25700299/d1089e4e-30cf-11e7-8583-eba4963b3136.png)

2. Создать БД с название hh, построенной по данной схеме ![database_scr](https://cloud.githubusercontent.com/assets/28348635/25700197/31a7553e-30cf-11e7-8fd5-3f047bfa3b40.PNG)

3. Заполнить БД данными с помощью программы [hhparser](https://github.com/GaPanda/hhparser) по запросу IT-технологии

4. Сохранить все действия

### Установка скомпилированнной программы:

1.Скачать архив по данной [ссылке](https://yadi.sk/d/7ZoIGHgG3HeUy9) .

2.Распаковать с помощью архиватора, например WinRar, на рабочий стол.

3.Скачать hhparser и выполнить необходимый алгоритм( в качестве запроса можно взять IT технологии)

4.Отредактировать файлы Form1.cs и new.cs. В строке SqlConnection cnn = new SqlConnection(@"Data Source=**ASUS\SQLEXPRES**;Initial Catalog=**hh**;Integrated Security=True"); подставить название своих БД и сервера. выделены жирным шрифтом

4.Запускать программу с помощью исполняемого файла 777.exe, который находится в корне папки с программой.

### Работа с программой:

1. После запуска программы, выберете из уже созданных запросов нужный или нажмите на кнопку "Создать новый". Чтобы увидеть отчет по данному запросу нажмитена кнопку "Показать отчет"
![2](https://cloud.githubusercontent.com/assets/28348635/25694905/8fa52834-30b9-11e7-8ec6-2d37d25a46e3.png)
2. После нажатия кнопки "Создать новый", введите скрипт запроса на sql. После этого нажмите "Выполнить".
3. Чтобы отобразить диаграмму, необходимо ввести в качестве значений навзания столбцов из таблицы, а далее нажать кнопку "Отобразить диаграмму".
4. Чтобы ввести новый запрос, необходимо нажать на кнопку "Отчистить поля"и ввести новые значения. 
![1](https://cloud.githubusercontent.com/assets/28348635/25694866/5e0befce-30b9-11e7-94ad-c4c1ff7b8bc4.png)

### Пример работы с программой:
1. Запускаю программу, выбираю любое название запроса. Вмоем случае "Максимальная зарплата по станциям метро". В твблице указан результат выполнения этого запроса. ![1](https://cloud.githubusercontent.com/assets/28348635/25700587/03299c92-30d1-11e7-9586-b81a4108fdd3.png)

2. Чтобы посмотреть отчет по запросу, необходимо нажать на кнопку "Показать отчет". После того как это сделать, откроется файл с отчетом по этому запросу в приложении Power BI(**Не забудьте его установить!**)
![1](https://cloud.githubusercontent.com/assets/28348635/25700786/d742370a-30d1-11e7-85ab-9efb817ee89e.png)

3. После просмотра отчета, возвращаюсь к окну программы.

4. Для создания нового запроса, необходимо нажать на кнопку "Создать новый". Появляется новое окно.

5. В поле, где меня прросят ввести запрос печатаю запрос на SQL языке!, в данном случае запрос выгляди так: ***select Experience.text_experience as 'Опыт', count(distinct Name_vacancy.id_name_vacancy) as 'Количество вакансий' from Experience,Name_vacancy,Vacancy where Experience.id_experience=Vacancy.id_experience and Vacancy.id_name_vacancy=Name_vacancy.id_name_vacancy group by Experience.text_experience.*** 

**Обратите внимание! что ключевое слово Go в конце запроса не ставится.** ![1](https://cloud.githubusercontent.com/assets/28348635/25700918/8f2187ea-30d2-11e7-9ced-710ce901f694.png)

6. После того, как программы выполнит запрос, появлется в таблице результат этого запроса. 

7. Чтобы увидеть диаграмму по такому запросу, нужно в поля "Значение 1" и "Значение 2", ввести название столбцов, по которым будет строиться диаграмма, а далее нажать на кнопку "Отобразить диаграмму" (В моем случае в поле со "Значение 1" ввожу "Опыт", "Значение 2" - "Количество вакансий"). ![1](https://cloud.githubusercontent.com/assets/28348635/25694866/5e0befce-30b9-11e7-94ad-c4c1ff7b8bc4.png)

8. Чтобы ввести новый запрос, необходимо нажать на кнопку "Отчистить поля"и ввести новые значения. 

