Разработан с целью анализа данных с сайта hh.ru 

Разработка производилась в операционной среде Windows. Работоспособность программы на UNIX-подобных ОС не проверялась. На данный момент программа умеет работать только с базами данных MSSQL Server, в дальнейшем список будет пополняться.

### Необходимые программы:

1. [MSSQL Server 2008 Express](https://www.microsoft.com/ru-ru/download/details.aspx%3Fid%3D1695)
Необходим для создания БД.

2. [MS Power BI](https://powerbi.microsoft.com/ru-ru/downloads/)
Необходим для визуализации анализа данных.

3. [hhparser](https://github.com/GaPanda/hhparser)
С помощью этой программы происходит загрузка данных в БД

4. [Microsoft Visual Studio](https://www.visualstudio.com/ru/downloads/)

![default](https://cloud.githubusercontent.com/assets/28348635/25701820/b42c5f34-30d6-11e7-92c9-833e669acea3.png)

### Работа с SQL Server
1.Скачать [MSSQL Server 2008 Express](https://www.microsoft.com/ru-ru/download/details.aspx%3Fid%3D1695)

2. Запустить exe-ный файл, открыть его, выбрать расположение куда будет загружаться данный файл. 
![1](https://cloud.githubusercontent.com/assets/28348635/25704336/b651d856-30e1-11e7-9f87-56a50a89f8e6.png)

3. После установки открыть файл setup.exe.

4. В окне "Центр установки SQL server" нажать "Установка"-"Новая установка изолированного SQL Server или добавление компонентов к существующему экземпляру"
![1](https://cloud.githubusercontent.com/assets/28348635/25704591/bfcab4ba-30e2-11e7-9b37-32adc5b7eb42.png)

5. После установки правил поддержки, нажмите "ОК".
![1](https://cloud.githubusercontent.com/assets/28348635/25704752/65ac8228-30e3-11e7-84c8-2a71ccfaa974.png)

6. Выберете тип устанвки: "Выполнить новую установку"

7. В окне "Ключ продукта" укажите свободный выпуск, согласитесь с условиями лицензии, выберете компоненты для установки
![1](https://cloud.githubusercontent.com/assets/28348635/25704926/14d5a05e-30e4-11e7-9190-db555ab5e26d.png)

8. Введите название сервера в поле "Именнованый экземпляр" 
![1](https://cloud.githubusercontent.com/assets/28348635/25705025/7c71659a-30e4-11e7-9627-8990df0787d3.png)

9.Установите SQL Server
![1](https://cloud.githubusercontent.com/assets/28348635/25705108/c0eb06ae-30e4-11e7-8cdb-e9c36f616ccd.png)

10. После установки запустите этот файл 

![default](https://cloud.githubusercontent.com/assets/28348635/25719522/739ad950-3112-11e7-8283-1ef323c2f04e.png)

11. Подключитесь к серверу 

![default](https://cloud.githubusercontent.com/assets/28348635/25719710/fdaf0030-3112-11e7-989a-96c8db6b46f1.png)

12. Создать БД с название hh, построенной по данной схеме ![database_scr](https://cloud.githubusercontent.com/assets/28348635/25700197/31a7553e-30cf-11e7-8fd5-3f047bfa3b40.PNG)

13.Чтобы создать БД, необходимо скачать [здесь](https://github.com/GaPanda/hhparser) архив. Распаковать с помощью архиватора. Найти папку mssql и открыть файл crebas.sql в sql exspress/

14. После открытия файла, нажать на кнопку "Выполнить". Ваша БД создана. 
![1](https://cloud.githubusercontent.com/assets/28348635/25705488/251f2988-30e6-11e7-9877-e62eaf3bce91.png)

15. Заполнить БД данными с помощью программы [hhparser](https://github.com/GaPanda/hhparser) по запросу IT-технологии

16. Сохранить все действия

### Установка скомпилированной программы:

1.Скачать архив по данной [ссылке](https://yadi.sk/d/MAmOOowL3JZvAn) .

2.Распаковать с помощью архиватора, например WinRar, на рабочий стол.

3.Скачать hhparser и выполнить необходимый алгоритм( в качестве запроса можно взять IT )

4.Отредактировать файлы Form1.cs и new.cs. В строке SqlConnection cnn = new SqlConnection(@"Data Source=**ASUS\SQLEXPRES**;Initial Catalog=**hh**;Integrated Security=True"); подставить название своих БД и сервера. выделены жирным шрифтом

4.Запускать программу с помощью исполняемого файла 777.exe, который находится в корне папки с программой.

###  Пример работы с программой:

1. После запуска программы, открывается меню и перед пользователем стоит выбор: поиск данных, анализ данных. ![44](https://cloud.githubusercontent.com/assets/28348635/26520212/07ef214e-42d7-11e7-8ce7-935567f27b36.png)

2.Нажав на «Поиск данных» возникает новое окно – окно поиска вакансий. В текстовое поле необходимо ввести запрос, например: «”ГУАП”,”Power BI”,”IT”», и нажать на кнопку «Найти вакансии». 
![3](https://cloud.githubusercontent.com/assets/28348635/26520251/5c1edc82-42d7-11e7-97e9-67f8d2d3b192.png)

3. Далее в высветившимся списке вакансии выбрать одну, полную информацию о которой вы хотите найти, ее название сразу дублируется в другое текстовое поле. Выберем «Аналитик» 
![4](https://cloud.githubusercontent.com/assets/28348635/26520258/895085d4-42d7-11e7-904e-2d452c936048.png)

4.Как видно вся информация об этой вакансии, которая хранилась в базе данных, была найдена. Однако может быть и такое, что какой-либо информации нет. Выберем «Affiliate marketing manager / Account manager». Как видно по этой вакансии были найдены только название компании, опыт работы и зарплата. 
![23](https://cloud.githubusercontent.com/assets/28348635/26520266/b477afb2-42d7-11e7-9f55-f1a1d1cc0a27.png)

5.Чтобы ввести новый запрос, нужно нажать на кнопку «Отчистить поле» и ввести новые значения.

6. Если вашего запроса не оказалось в базе данных, то выскакивает сообщение «Такого запроса в БД не нашлось», и предлагается загрузка данных в БД с помощью программы «hhparser.ru». Если пользователь ответит «Да», то запустится эта программа, а если «Нет», то сообщение закроется
![6](https://cloud.githubusercontent.com/assets/28348635/26520286/1a500e1a-42d8-11e7-9782-e4b3d459525b.png)

7.Нажав на «Анализ данных», появляется другое окно
![12](https://cloud.githubusercontent.com/assets/28348635/26520292/3e625f7e-42d8-11e7-8811-c82908c1cb33.png)

8.С помощью флажка можно выбрать уже существующий запрос, увидеть его анализ и визуализацию. Чтобы посмотреть отчет необходимо нажать на кнопку «Показать отчет». Далее откроется среда MS Power BI, в которой этот отчет находится.
![124](https://cloud.githubusercontent.com/assets/28348635/26520303/5d4c0886-42d8-11e7-9d50-7f5f23a5e312.png)
![56](https://cloud.githubusercontent.com/assets/28348635/26520307/691f4970-42d8-11e7-8c7c-f6451b5fdb8f.png)

9.После просмотра, возвращайтесь к окну программы. Чтобы создать новый отчет, нужно кликнуть по кнопке «Создать новый». Откроется новое окно
![67](https://cloud.githubusercontent.com/assets/28348635/26520314/82049292-42d8-11e7-8e17-61cc16497f2d.png)

10.В текстовое поле вводим поисковой запрос на sql-языке. Например, введем следующий запрос и нажмем «Выполнить»:
select distinct Experience.text_experience as 'Опыт', count(distinct Name_vacancy.id_name_vacancy) as 'Количество вакансий' from Experience,Name_vacancy,Vacancy,Query_vacancy,Query_name,Query where Query_vacancy.id_vacancy=Vacancy.id_vacancy and Query_name.id_query_name = Query.id_query_name and Query.id_query = Query_vacancy.id_query and name_query='"IT"' and Experience.id_experience = Vacancy.id_experience and Vacancy.id_name_vacancy = Name_vacancy.id_name_vacancy group by Experience.text_experience
Обратите внимание, что в конце запроса не ставиться слово go! 
![76](https://cloud.githubusercontent.com/assets/28348635/26520317/9ed22d30-42d8-11e7-84ea-8bfbff76e863.png)

11. В поле появился результат выполнения запроса. Чтобы отобразить диаграмму, необходимо ввести в качестве значений названия столбцов из таблицы, выбрать тип отображения данных (Столбчатая диаграмма, круговая диаграмма, график), а далее нажать кнопку "Отобразить диаграмму".
![1245](https://cloud.githubusercontent.com/assets/28348635/26520320/b14202ce-42d8-11e7-9474-c98fcd637551.png)
![54](https://cloud.githubusercontent.com/assets/28348635/26520325/ba7cc69e-42d8-11e7-899c-21171eea23df.png)
![764](https://cloud.githubusercontent.com/assets/28348635/26520329/c1e1b6e2-42d8-11e7-9c29-c54f16de1c76.png)

12. Чтобы ввести новый запрос, необходимо нажать на кнопку «Отчистить поле» и ввести новые значения.

