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
using System.Data;

namespace Kinoteatr
{
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        DataBase database = new DataBase(); 
        public UserPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) 
        {
            //получение значений с полей логи и пароль
            var logReg = Log.Text;                                 
            var regReg = Pas.Password;                   

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select ID_User, loginUser, passUser from User1 where loginUser='{logReg}' and passUser='{regReg}' "; //поиск пользователя в бд

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)  //если такой пользователь есть
            {
                MessageBox.Show("Вы успешно вошли");
                NavigationService.Navigate(new UserPageosn());
            }
            else                         //если пользователя нет
                MessageBox.Show("Такого аккаунта нет");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack(); //переход назад
        }

        private void Button_Click(object sender, object e)
        {

        }
    }
}
