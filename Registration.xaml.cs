using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data.Entity;

namespace Kinoteatr
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        DataBase dataBase = new DataBase();
        public Registration()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack(); //навигация
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //получение данных 
        {
            var logReg = Log.Text;
            var regReg = Pas.Password;
            var regFam = Fam.Text;
            var regName = Name.Text;
            var otchReg = Otch.Text;
            var emailReg = email.Text;
            var phoneReg = Phone.Text;

            //создание запроса на вставку в бд
            string querystring = $"insert into User1(loginUser, passUser, Fama, Name, Otch, EmailUser, phoneUser) values('{logReg}', '{regReg}', '{regFam}', '{regName}', '{otchReg}', '{emailReg}', '{phoneReg}')";
            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
            dataBase.openConnection();                                                        //открытие соединения
            if (command.ExecuteNonQuery() == 1)                  //проверка на ошибки
            {
                MessageBox.Show("Аккаунт создан");
                NavigationService.Navigate(new UserPage());
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
            dataBase.closeConnection();
            

            
        }
    }
}
