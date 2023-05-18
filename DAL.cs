using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using System.Data.SqlClient;
using System.Data.Common;
using System.Globalization;
using System.IO;
using System.Configuration;

namespace company
{
    class DAL
    {

        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=company;Integrated Security=True";
        //string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=company; User ID=B; Password=123;";
        ///string connectionString = string.Format(@"Data Source=.\SQLEXPRESS; Initial Catalog=company; User ID='{0}'; Password='{1}';", Pas.log,Pas.password);
        //string connectionString = ConfigurationManager.ConnectionStrings["Company"].ConnectionString;


        public ArrayList GetAllWorker()
        {
            
            //private SqlConnection
            
            ArrayList worker = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("Select Сотрудники.ID, ФИО, Пол, [Дата рождения], Адрес, [Семейное положение], Образование, Специальность, Диплом, [Опыт работы], Отделы.Отдел, Должности.Должность from Сотрудники left join Отделы On Отделы.ID = Сотрудники.[ID отдела] left join Должности on Должности.ID = Сотрудники.[ID должности]", con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr) // foreach служит для циклического обращения к элементам коллекции
                            worker.Add(result);
                }
                catch
                {

                }
            }
            return worker;
        }
        public ArrayList GetAllDepartments()
        {

            ArrayList department = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("Select * From Отделы", con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr) // foreach служит для циклического обращения к элементам коллекции
                            department.Add(result);
                }
                catch
                {

                }
            }
            return department;
        }
        public ArrayList GetAllPositions()
        {

            ArrayList position = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("Select * From Должности", con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr) // foreach служит для циклического обращения к элементам коллекции
                            position.Add(result);
                }
                catch
                {

                }
            }
            return position;
        }
        public ArrayList GetAllSales()
        {

            ArrayList sales = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("Select Продажи.ID, Клиенты.ФИО as [ФИО клиента], wt.ФИОсотрудника, услуга, Дата From Продажи " +
                    "Left Join Услуги On Услуги.ID = Продажи.IDуслуги left join Сотрудники on Сотрудники.ID = Продажи.IDсотрудник " +
                    "left join Клиенты on Клиенты.ID = Продажи.IDклиент left JOIN (SELECT Продажи.ID, CONCAT(Сотрудники.ФИО, Увольнения.ФИО) " +
                    "AS ФИОсотрудника FROM Продажи left join Сотрудники on Сотрудники.ID = Продажи.IDсотрудник " +
                    "left join Увольнения on Увольнения.ID = Продажи.IDуволеногосотрудника) as wt on  Продажи.ID = wt.ID; ", con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr) // foreach служит для циклического обращения к элементам коллекции
                            sales.Add(result);
                }
                catch
                {

                }
            }
            return sales;
        }
        public ArrayList GetAllServices()
        {

            ArrayList services = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("Select * From Услуги", con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr) // foreach служит для циклического обращения к элементам коллекции
                            services.Add(result);
                }
                catch
                {

                }
            }
            return services;
        }
        public ArrayList GetAllWorkerAddInfo()
        {
            ArrayList worker = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = "Select AddInfo.ID, ФИО, НомерСерияПаспорта, НомерТрудовойКнижки, [Дата приёма на работу], [Номер телефона], Гражданство," +
                    " ИНН, СНИЛС, Фото from AddInfo left join Сотрудники on AddInfo.ID = Сотрудники.ID ";
                SqlCommand com = new SqlCommand(sql, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr) // foreach служит для циклического обращения к элементам коллекции
                            worker.Add(result);
                }
                catch
                {

                }
            }
            return worker;

        }
        public ArrayList GetWorkerAddInfo(int ID)
        {
            ArrayList worker = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = string.Format("Select AddInfo.ID, ФИО, НомерСерияПаспорта, НомерТрудовойКнижки, [Дата приёма на работу], " +
                    "[Номер телефона], Гражданство, ИНН, СНИЛС, Фото" +
                    " from AddInfo left join Сотрудники on AddInfo.ID = Сотрудники.ID Where Сотрудники.ID = '{0}'  ", ID);
                SqlCommand com = new SqlCommand(sql, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr) // foreach служит для циклического обращения к элементам коллекции
                            worker.Add(result);
                }
                catch
                {

                }
            }
            return worker;

        }
        public ArrayList GetAllClients()
        {
            ArrayList Clients = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("Select * From Клиенты", con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr) // foreach служит для циклического обращения к элементам коллекции
                            Clients.Add(result);
                }
                catch
                {

                }
            }
            return Clients;
        }
        public ArrayList GetAllDismissedWorker()
        {
            ArrayList DismissedWorker = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("Select Увольнения.[№ Документа] as '№',Увольнения.ID, ФИО, Отделы.Отдел, Должности.Должность, Статья, Причина, [Дата увольнения]  From Увольнения Left Join Отделы On Увольнения.IDотдел = Отделы.ID left join Должности on Увольнения.IDдолжность = Должности.ID", con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr) // foreach служит для циклического обращения к элементам коллекции
                            DismissedWorker.Add(result);
                }
                catch
                {

                }
            }
            return DismissedWorker;
        }

        internal bool SaveBD(string filename, int table) //создание и запись информации в файл
        {
            bool result = true;

            StreamWriter file;
                               //StreamWriter file = new StreamWriter(new FileStream("Debitors.csv", FileMode.Create), Encoding.GetEncoding(1251)); //StreamWriter(Файл,кодировка)
                               //new FileStream("Debitors.csv",FileMode.Create) - создали файл Debitors.csv с типом FileStream
                               //StreamWriter - тип файла для записи в него данных
            string query;
            if (table == 1)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        file = new StreamWriter(new FileStream(filename, FileMode.Create), Encoding.GetEncoding(1251)); //StreamWriter(Файл,кодировка)
                        query = "Select * From Сотрудники";
                        SqlCommand com = new SqlCommand(query, con);
                        con.Open();
                        SqlDataReader reader = com.ExecuteReader();

                        file.WriteLine("Start of file");
                        file.WriteLine(@"""ID"";""ФИО"";""Пол"";""Дата Рождения "";""Адрес"";""Семейное положение"";""Образование"";""Специальность"";""Диплом"";""Опыт работы"";""Отдел"";""Должность"""); //записываем в файл название сталбцов

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                file.WriteLine(@"""" + reader.GetValue(0).ToString() + @""";""" + reader.GetString(1)
                                    + @""";""" + reader[2].ToString() + @""";""" + reader.GetDateTime(3) + @""";""" + reader[4].ToString() + @""";"""
                                    + reader[5].ToString() + @""";""" + reader[6].ToString() + @""";""" + reader[7].ToString() + @""";"""
                                    + reader[8].ToString() + @""";""" + reader[9].ToString() + @""";""" + reader.GetValue(10) + @""";"""
                                    + reader.GetValue(11) + @""";""" + @"""", Encoding.ASCII);
                            }// записываем данные по ячейкам

                        }
                        else
                        {
                            file.WriteLine("No one row to save");
                        }
                        file.WriteLine("End of file");
                        file.Dispose();
                    }
                    catch
                    {
                        result = false;
                        return result;
                    }
                }
            }
            if (table == 2)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        file = new StreamWriter(new FileStream(filename, FileMode.Create), Encoding.GetEncoding(1251)); //StreamWriter(Файл,кодировка)
                                                                                                                        //new FileStream("Credits.csv",FileMode.Create) - создали файл Credits.csv с типом FileStream
                                                                                                                        //StreamWriter - тип файла для записи в него данных
                        query = "Select * From Отделы";
                        SqlCommand com = new SqlCommand(query, con);
                        con.Open();
                        SqlDataReader reader = com.ExecuteReader();

                        file.WriteLine("Start of file");
                        file.WriteLine(@"""ID"";""Отдел"""); //записываем в файл название сталбцов

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                file.WriteLine(@"""" + reader.GetValue(0).ToString() + @""";""" + reader.GetString(1) + @"""", Encoding.ASCII);
                            }// записываем данные по ячейкам

                        }
                        else
                        {
                            file.WriteLine("No one row to save");
                        }
                        file.WriteLine("End of file");
                        file.Dispose();
                    }
                    catch
                    {
                        result = false;
                        return result;
                    }
                }
            }
            if (table == 3)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        file = new StreamWriter(new FileStream(filename, FileMode.Create), Encoding.GetEncoding(1251)); //StreamWriter(Файл,кодировка)
                                                                                                                        //new FileStream("Credits.csv",FileMode.Create) - создали файл Credits.csv с типом FileStream
                                                                                                                        //StreamWriter - тип файла для записи в него данных
                        query = "Select * From Должности";
                        SqlCommand com = new SqlCommand(query, con);
                        con.Open();
                        SqlDataReader reader = com.ExecuteReader();

                        file.WriteLine("Start of file");
                        file.WriteLine(@"""ID"";""Должность"""); //записываем в файл название сталбцов

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                file.WriteLine(@"""" + reader.GetValue(0).ToString() + @""";""" + reader.GetString(1) + @"""", Encoding.ASCII);
                            }// записываем данные по ячейкам

                        }
                        else
                        {
                            file.WriteLine("No one row to save");
                        }
                        file.WriteLine("End of file");
                        file.Dispose();
                    }
                    catch
                    {
                        result = false;
                        return result;
                    }
                }
            }
            if (table == 4)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        file = new StreamWriter(new FileStream(filename, FileMode.Create), Encoding.GetEncoding(1251)); //StreamWriter(Файл,кодировка)
                        query = "Select * From Продажи";
                        SqlCommand com = new SqlCommand(query, con);
                        con.Open();
                        SqlDataReader reader = com.ExecuteReader();

                        file.WriteLine("Start of file");
                        file.WriteLine(@"""ID"";""IDКлиент"";""IDуслуга"";""Дата"";""IDсотрудник"""); //записываем в файл название сталбцов

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                file.WriteLine(@"""" + reader.GetValue(0).ToString() + @""";""" + reader.GetString(1)
                                    + @""";""" + reader[2].ToString() + @""";""" + reader.GetDateTime(3) + @"""", Encoding.ASCII);
                            }// записываем данные по ячейкам

                        }
                        else
                        {
                            file.WriteLine("No one row to save");
                        }
                        file.WriteLine("End of file");
                        file.Dispose();
                    }
                    catch
                    {
                        result = false;
                        return result;
                    }
                }
            }
            if (table == 5)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        file = new StreamWriter(new FileStream(filename, FileMode.Create), Encoding.GetEncoding(1251)); //StreamWriter(Файл,кодировка)
                        query = "Select * From Услуги";
                        SqlCommand com = new SqlCommand(query, con);
                        con.Open();
                        SqlDataReader reader = com.ExecuteReader();

                        file.WriteLine("Start of file");
                        file.WriteLine(@"""ID"";""Услуга"";""Цена"";""Гарантия, лет"""); //записываем в файл название сталбцов

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                file.WriteLine(@"""" + reader.GetValue(0).ToString() + @""";""" + reader.GetString(1)
                                    + @""";""" + reader.GetValue(2).ToString() + @""";""" + reader[3].ToString() + @"""", Encoding.ASCII);
                            }// записываем данные по ячейкам

                        }
                        else
                        {
                            file.WriteLine("No one row to save");
                        }
                        file.WriteLine("End of file");
                        file.Dispose();
                    }
                    catch
                    {
                        result = false;
                        return result;
                    }
                }
            }
            return result;
        }

        internal bool SaveAllBD() //создание и запись информации в файл
        {
            bool result = true;

            StreamWriter file;
            //StreamWriter file = new StreamWriter(new FileStream("Debitors.csv", FileMode.Create), Encoding.GetEncoding(1251)); //StreamWriter(Файл,кодировка)
            //new FileStream("Debitors.csv",FileMode.Create) - создали файл Debitors.csv с типом FileStream
            //StreamWriter - тип файла для записи в него данных
            string query;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    file = new StreamWriter(new FileStream("Сотрудники.csv", FileMode.Create), Encoding.GetEncoding(1251)); //StreamWriter(Файл,кодировка)
                    query = "Select * From Сотрудники";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();

                    file.WriteLine("Start of file");
                    file.WriteLine(@"""ID"";""ФИО"";""Пол"";""Дата Рождения "";""Адрес"";""Семейное положение"";""Образование"";""Специальность"";""Диплом"";""Опыт работы"";""Отдел"";""Должность"""); //записываем в файл название сталбцов

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            file.WriteLine(@"""" + reader.GetValue(0).ToString() + @""";""" + reader.GetString(1)
                                + @""";""" + reader[2].ToString() + @""";""" + reader.GetDateTime(3) + @""";""" + reader[4].ToString() + @""";"""
                                + reader[5].ToString() + @""";""" + reader[6].ToString() + @""";""" + reader[7].ToString() + @""";"""
                                + reader[8].ToString() + @""";""" + reader[9].ToString() + @""";""" + reader.GetValue(10) + @""";"""
                                + reader.GetValue(11) + @""";""" + @"""", Encoding.ASCII);
                        }// записываем данные по ячейкам

                    }
                    else
                    {
                        file.WriteLine("No one row to save");
                    }
                    file.WriteLine("End of file");
                    file.Dispose();
                }
                catch
                {
                    result = false;
                    return result;
                }
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    file = new StreamWriter(new FileStream("Отделы.csv", FileMode.Create), Encoding.GetEncoding(1251)); //StreamWriter(Файл,кодировка)
                                                                                                                    //new FileStream("Credits.csv",FileMode.Create) - создали файл Credits.csv с типом FileStream
                                                                                                                    //StreamWriter - тип файла для записи в него данных
                    query = "Select * From Отделы";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();

                    file.WriteLine("Start of file");
                    file.WriteLine(@"""ID"";""Отдел"""); //записываем в файл название сталбцов

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            file.WriteLine(@"""" + reader.GetValue(0).ToString() + @""";""" + reader.GetString(1) + @"""", Encoding.ASCII);
                        }// записываем данные по ячейкам

                    }
                    else
                    {
                        file.WriteLine("No one row to save");
                    }
                    file.WriteLine("End of file");
                    file.Dispose();
                }
                catch
                {
                    result = false;
                    return result;
                }
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    file = new StreamWriter(new FileStream("Должности.csv", FileMode.Create), Encoding.GetEncoding(1251)); //StreamWriter(Файл,кодировка)
                                                                                                                       //new FileStream("Credits.csv",FileMode.Create) - создали файл Credits.csv с типом FileStream
                                                                                                                       //StreamWriter - тип файла для записи в него данных
                    query = "Select * From Должности";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();

                    file.WriteLine("Start of file");
                    file.WriteLine(@"""ID"";""Должность"""); //записываем в файл название сталбцов

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            file.WriteLine(@"""" + reader.GetValue(0).ToString() + @""";""" + reader.GetString(1) + @"""", Encoding.ASCII);
                        }// записываем данные по ячейкам

                    }
                    else
                    {
                        file.WriteLine("No one row to save");
                    }
                    file.WriteLine("End of file");
                    file.Dispose();
                }
                catch
                {
                    result = false;
                    return result;
                }
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    file = new StreamWriter(new FileStream("Продажи.csv", FileMode.Create), Encoding.GetEncoding(1251)); //StreamWriter(Файл,кодировка)
                    query = "Select * From Продажи";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();

                    file.WriteLine("Start of file");
                    file.WriteLine(@"""ID"";""IDКлиент"";""IDуслуга"";""Дата"";""IDсотрудник"""); //записываем в файл название сталбцов

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            file.WriteLine(@"""" + reader.GetValue(0).ToString() + @""";""" + reader.GetString(1)
                                + @""";""" + reader[2].ToString() + @""";""" + reader.GetDateTime(3) + @""";""" + reader[4].ToString() + @"""", Encoding.ASCII);
                        }// записываем данные по ячейкам

                    }
                    else
                    {
                        file.WriteLine("No one row to save");
                    }
                    file.WriteLine("End of file");
                    file.Dispose();
                }
                catch
                {
                    result = false;
                    return result;
                }
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    file = new StreamWriter(new FileStream("Услуги.csv", FileMode.Create), Encoding.GetEncoding(1251)); //StreamWriter(Файл,кодировка)
                    query = "Select * From Услуги";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();

                    file.WriteLine("Start of file");
                    file.WriteLine(@"""ID"";""Услуга"";""Цена"";""Гарантия, лет"""); //записываем в файл название сталбцов

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            file.WriteLine(@"""" + reader.GetValue(0).ToString() + @""";""" + reader.GetString(1)
                                + @""";""" + reader.GetValue(2).ToString() + @""";""" + reader[3].ToString() + @"""", Encoding.ASCII);
                        }// записываем данные по ячейкам

                    }
                    else
                    {
                        file.WriteLine("No one row to save");
                    }
                    file.WriteLine("End of file");
                    file.Dispose();
                }
                catch
                {
                    result = false;
                    return result;
                }
            }

            return result;
        }

        public bool SaveNewWorker(string ФИО, string Пол, DateTime ДР, string Адрес, string СП, string Образование, string Спец, string Диплом, int ОР, int IDо, int IDд)
        {
            bool flagResult = false;
            string query = string.Format("Insert into Сотрудники (ФИО, Пол, [Дата рождения], Адрес," +
                " [Семейное положение], Образование, Специальность, Диплом, [Опыт работы],[ID отдела],[ID должности])" +
                "Values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', " +
                "'{10}')", ФИО,Пол,ДР, Адрес, СП, Образование, Спец, Диплом, ОР, IDо, IDд);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1) //Возвращает колличество изменённых строк
                        flagResult = true;
                }
                catch
                {

                }
            }


            return flagResult;
        }
        public bool DeleteWorker(int num)
        {
            bool flagResult = false;
            string query = string.Format("DELETE FROM Сотрудники WHERE ID='{0}'", num); //@RowID
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1) //Возвращает колличество изменённых строк
                        flagResult = true;
                }
                catch
                {

                }
            }


            return flagResult;
        }
        
        public bool AddDismissWorker(int ID, string ФИО, int Отдел, int Должность, string Статья, string Причина, DateTime date)
        {
            bool flagResult = false;
            string query = string.Format("Insert Into Увольнения(ID, ФИО, IDотдел, IDдолжность, Статья , Причина, [Дата увольнения]) " +
                "Values('{0}','{1}', '{2}', '{3}', '{4}', '{5}', '{6}');", ID, ФИО, Отдел, Должность, Статья, Причина, date); //@RowID
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1) //Возвращает колличество изменённых строк
                        flagResult = true;
                }
                catch
                {

                }
            }


            return flagResult;
        }
        public ArrayList SortByОтдел(int IDотдела)
        {
            ArrayList worker = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = string.Format("Select Сотрудники.ID, ФИО, Пол, [Дата рождения], Адрес, [Семейное положение], Образование, Специальность, " +
                    "Диплом, [Опыт работы], Отделы.Отдел, Должности.Должность from Сотрудники left join Отделы On Отделы.ID = Сотрудники.[ID отдела] " +
                    "left join Должности on Должности.ID = Сотрудники.[ID должности] Where Отделы.ID = '{0}'", IDотдела);
                SqlCommand com = new SqlCommand(sql, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr) // foreach служит для циклического обращения к элементам коллекции
                            worker.Add(result);
                }
                catch
                {

                }
            }
            return worker;

        }
        public ArrayList SortByДолжность(int IDдолжность)
        {
            ArrayList worker = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = string.Format("Select Сотрудники.ID, ФИО, Пол, [Дата рождения], Адрес, [Семейное положение], Образование, Специальность, " +
                    "Диплом, [Опыт работы], Отделы.Отдел, Должности.Должность from Сотрудники left join Отделы On Отделы.ID = Сотрудники.[ID отдела] " +
                    "left join Должности on Должности.ID = Сотрудники.[ID должности] Where Должности.ID = '{0}'", IDдолжность);
                SqlCommand com = new SqlCommand(sql, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr) // foreach служит для циклического обращения к элементам коллекции
                            worker.Add(result);
                }
                catch
                {

                }
            }
            return worker;

        }
        public ArrayList SortByОтдел(int IDотдела,int IDдолжность)
        {
            ArrayList worker = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = string.Format("Select Сотрудники.ID, ФИО, Пол, [Дата рождения], Адрес, [Семейное положение], Образование, Специальность, " +
                    "Диплом, [Опыт работы], Отделы.Отдел, Должности.Должность from Сотрудники left join Отделы On Отделы.ID = Сотрудники.[ID отдела] " +
                    "left join Должности on Должности.ID = Сотрудники.[ID должности] Where Отделы.ID = '{0}' and Должности.ID = '{1}'", IDотдела,IDдолжность);
                SqlCommand com = new SqlCommand(sql, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr) // foreach служит для циклического обращения к элементам коллекции
                            worker.Add(result);
                }
                catch
                {

                }
            }
            return worker;

        }

        public ArrayList Searchсотрудник(string ФИО)
        {
            ArrayList worker = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = string.Format("Select Сотрудники.ID, ФИО, Пол, [Дата рождения], Адрес, [Семейное положение], Образование, Специальность, " +
                    "Диплом, [Опыт работы], Отделы.Отдел, Должности.Должность from Сотрудники left join Отделы On Отделы.ID = Сотрудники.[ID отдела] " +
                    "left join Должности on Должности.ID = Сотрудники.[ID должности] Where Сотрудники.ФИО like '%'+'{0}'+'%'", ФИО);
                SqlCommand com = new SqlCommand(sql, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr) // foreach служит для циклического обращения к элементам коллекции
                            worker.Add(result);
                }
                catch
                {

                }
            }
            return worker;

        }

        public bool Additional_Info_ChangeCell(string NameColumn, string info, int ID)
        {
            bool flagResult = false;
            string query = string.Format("UPDATE AddInfo SET {0} = '{1}' WHERE ID = {2} ", NameColumn,info, ID); 
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1) //Возвращает колличество изменённых строк
                        flagResult = true;
                }
                catch
                {

                }
            }


            return flagResult;
        }
        public bool DeleteAdditionalInfo(int num)
        {
            bool flagResult = false;
            string query = string.Format("DELETE FROM AddInfo WHERE ID = '{0}'", num); //@RowID
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1) //Возвращает колличество изменённых строк
                        flagResult = true;
                }
                catch
                {

                }
            }


            return flagResult;
        }

        public bool SaveAdditionalInfo(string ФИО, string num1, string num2, DateTime date, string phone, string гражданство, string ИНН, string СНИЛС)
        {
            bool flagResult = false;
            string query = string.Format("Insert into AddInfo (ID, НомерСерияПаспорта, НомерТрудовойКнижки, [Дата приёма на работу], [Номер телефона]," +
                " Гражданство, ИНН, СНИЛС) Values ((Select ID from Сотрудники Where ФИО = '{0}'), '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", 
                ФИО, num1, num2, date, phone, гражданство, ИНН, СНИЛС);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1) //Возвращает колличество изменённых строк
                        flagResult = true;
                }
                catch
                {

                }
            }


            return flagResult;
        }

        

        public bool AddDepartments(string отдел)
        {
            bool flagResult = false;
            string query = string.Format("Insert Into Отделы values('{0}')", отдел);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1) 
                        flagResult = true;
                }
                catch
                {

                }
            }


            return flagResult;
        }

        public bool DeleteDepartment(int num)
        {
            bool flagResult = false;
            string query = string.Format("DELETE FROM Отделы WHERE ID = '{0}'", num); //@RowID
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1) //Возвращает колличество изменённых строк
                        flagResult = true;
                }
                catch
                {

                }
            }


            return flagResult;
        }
        public bool AddPosition(string Должность)
        {
            bool flagResult = false;
            string query = string.Format("Insert Into Должности values('{0}')", Должность); //@RowID
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1) //Возвращает колличество изменённых строк
                        flagResult = true;
                }
                catch
                {

                }
            }


            return flagResult;
        }

        public bool DeletePosition(int num)
        {
            bool flagResult = false;
            string query = string.Format("DELETE FROM Должности WHERE ID = '{0}'", num); //@RowID
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1) //Возвращает колличество изменённых строк
                        flagResult = true;
                }
                catch
                {

                }
            }


            return flagResult;
        }

        public bool AddSales(string IDworker, string IDclient, string IDуслуга, DateTime date)
        {
            bool flagResult = false;
            string query = string.Format("Insert into Продажи(IDклиент,IDсотрудник,IDуслуги,Дата)" +
                " Values ((Select ID from Клиенты Where ФИО = '{0}'), (Select ID from Сотрудники Where ФИО = '{1}'), " +
                "(Select ID from Услуги Where Услуга = '{2}'), '{3}')",
                IDclient, IDworker, IDуслуга, date);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1) //Возвращает колличество изменённых строк
                        flagResult = true;
                }
                catch
                {

                }
            }


            return flagResult;
        }

        public bool DeleteSales(int num)
        {
            bool flagResult = false;
            string query = string.Format("DELETE FROM Продажи WHERE ID = '{0}'", num); //@RowID
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1) //Возвращает колличество изменённых строк
                        flagResult = true;
                }
                catch
                {

                }
            }


            return flagResult;
        }

        public bool UpdateSales(int num)
        {
            bool flagResult = false;
            string query = string.Format("Update Продажи Set IDуволеногосотрудника = '{0}' WHERE IDсотрудник = '{1}'", num, num); //@RowID
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1) //Возвращает колличество изменённых строк
                        flagResult = true;
                }
                catch
                {

                }
            }


            return flagResult;
        }

        public bool AddServices(string Услуга, int Цена, int Гарантия)
        {
            bool flagResult = false;
            string query = string.Format("Insert into Услуги Values ('{0}', '{1}', '{2}')", Услуга, Цена, Гарантия);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1) //Возвращает колличество изменённых строк
                        flagResult = true;
                }
                catch
                {

                }
            }


            return flagResult;
        }

        public bool DeleteService(int num)
        {
            bool flagResult = false;
            string query = string.Format("DELETE FROM Услуги WHERE ID = '{0}'", num); //@RowID
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1) //Возвращает колличество изменённых строк
                        flagResult = true;
                }
                catch
                {

                }
            }


            return flagResult;
        }

        public bool AddClient(string ФИО, DateTime Дата, string phone)
        {
            bool flagResult = false;
            string query = string.Format("Insert into Клиенты Values ('{0}', '{1}', '{2}')", ФИО, Дата, phone);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1) //Возвращает колличество изменённых строк
                        flagResult = true;
                }
                catch
                {

                }
            }


            return flagResult;
        }

        public bool DeleteClient(int num)
        {
            bool flagResult = false;
            string query = string.Format("DELETE FROM Клиенты WHERE ID = '{0}'", num); //@RowID
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1) //Возвращает колличество изменённых строк
                        flagResult = true;
                }
                catch
                {

                }
            }


            return flagResult;
        }

        public bool Service_ChangeCell(string NameColumn, string info, int ID)
        {
            bool flagResult = false;
            string query = string.Format("UPDATE Услуги SET {0} = '{1}' WHERE ID = {2} ", NameColumn, info, ID);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1) //Возвращает колличество изменённых строк
                        flagResult = true;
                }
                catch
                {

                }
            }


            return flagResult;
        }

        public ArrayList SearchSales(string ФИО)
        {
            ArrayList worker = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = string.Format("Select Продажи.ID, Клиенты.ФИО as [ФИО клиента], wt.ФИОсотрудника, услуга, Дата From Продажи " +
                    "Left Join Услуги On Услуги.ID = Продажи.IDуслуги left join Сотрудники on Сотрудники.ID = Продажи.IDсотрудник" +
                    " left join Клиенты on Клиенты.ID = Продажи.IDклиент left JOIN(SELECT Продажи.ID, CONCAT(Сотрудники.ФИО, Увольнения.ФИО)" +
                    "AS ФИОсотрудника FROM Продажи left join Сотрудники on Сотрудники.ID = Продажи.IDсотрудник" +
                    " left join Увольнения on Увольнения.ID = Продажи.IDуволеногосотрудника) as wt on  Продажи.ID = wt.ID where Клиенты.ФИО like '%{0}%'", ФИО);
                SqlCommand com = new SqlCommand(sql, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr) // foreach служит для циклического обращения к элементам коллекции
                            worker.Add(result);
                }
                catch
                {

                }
            }
            return worker;

        }

        public ArrayList SearchSales2(string ФИО)
        {
            ArrayList worker = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = string.Format("Select Продажи.ID, Клиенты.ФИО as [ФИО клиента], wt.ФИОсотрудника, услуга, Дата From Продажи " +
                    "Left Join Услуги On Услуги.ID = Продажи.IDуслуги left join Сотрудники on Сотрудники.ID = Продажи.IDсотрудник" +
                    " left join Клиенты on Клиенты.ID = Продажи.IDклиент left JOIN(SELECT Продажи.ID, CONCAT(Сотрудники.ФИО, Увольнения.ФИО)" +
                    "AS ФИОсотрудника FROM Продажи left join Сотрудники on Сотрудники.ID = Продажи.IDсотрудник" +
                    " left join Увольнения on Увольнения.ID = Продажи.IDуволеногосотрудника) as wt on  Продажи.ID = wt.ID where ФИОсотрудника like '%{0}%'", ФИО);
                SqlCommand com = new SqlCommand(sql, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr) // foreach служит для циклического обращения к элементам коллекции
                            worker.Add(result);
                }
                catch
                {

                }
            }
            return worker;

        }

        public int SummCostSalesOfMonth(string ФИО)
        {
            int sum = new int();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = string.Format("Select sum(Услуги.Цена) From Продажи Left join Услуги on Продажи.IDуслуги = Услуги.ID Where Продажи.Дата like '%-%{0}-%';", ФИО);
                SqlCommand com = new SqlCommand(sql, con);
                try
                {
                    con.Open();
                    object summ = com.ExecuteScalar();
                    sum = Convert.ToInt32(summ);
                    
                }
                catch
                {

                }
            }
            return sum;

        }
        
        public string GetCurrentDismissedWorker(int IDотдела)
        {
            ArrayList worker = new ArrayList();
            string myArray = string.Empty;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sql = string.Format("Select * FROM Увольнения WHERE ID = '{0}'", IDотдела);
                SqlCommand com = new SqlCommand(sql, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr) // foreach служит для циклического обращения к элементам коллекции
                            worker.Add(result);
                    
                    for (int i = 0; i < worker.Count; i++)
                        myArray += worker[i];
                    

                }
                catch
                {

                }
            }
            return myArray;

        }
        public bool UpdatePhoto(string w, int ID)
        {
            bool flagResult = false;
            string query = string.Format("Update AddInfo Set Фото = '{0}' WHERE ID = '{1}'", w, ID); //@RowID
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1) //Возвращает колличество изменённых строк
                        flagResult = true;

                }
                catch
                {

                }
            }


            return flagResult;
        }
        public bool UpdateAllAddInfo(string паспорт,string трудовая,DateTime Дата,string Телефон,string Гражданство,string ИНН,string СНИЛС, int ID)
        {
            bool flagResult = false;
            string query = string.Format("Update AddInfo Set НомерСерияПаспорта = '{0}', НомерТрудовойКнижки = '{1}', [Дата приёма на работу] = '{2}', " +
                "[Номер телефона] = '{3}', Гражданство = '{4}', ИНН = '{5}', СНИЛС = '{6}' WHERE ID = {7}", паспорт,трудовая,Дата,Телефон,Гражданство,
                ИНН,СНИЛС, ID); //@RowID
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1) //Возвращает колличество изменённых строк
                        flagResult = true;

                }
                catch
                {

                }
            }


            return flagResult;
        }
        public bool UpdateWorkerInfo(int ID, string ФИО, string Пол, DateTime Дата, string Адрес, string СП, string Обр, string Спец, string Диплом, int ОпытРаб)
        {
            bool flagResult = false;
            string query = string.Format("Update Сотрудники Set ФИО = '{0}', Пол = '{1}', [Дата рождения] = '{2}', Адрес = '{3}', [Семейное положение] = '{4}', " +
                "Образование = '{5}', Специальность = '{6}', Диплом = '{7}',[Опыт работы] = '{8}' WHERE ID = {9}", ФИО, Пол, Дата, Адрес, СП, Обр, Спец, Диплом, ОпытРаб, ID); //@RowID
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() >= 1) //Возвращает колличество изменённых строк
                        flagResult = true;

                }
                catch
                {

                }
            }


            return flagResult;
        }

        public bool password()
        {
            bool i = false;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    i = true;
                }
                catch
                {
                    i = false;
                }
            }
            return i;
        }
        
    }
}
