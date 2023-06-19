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

namespace Kinoteatr
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack(); //навигация
        }

        private void Button_Click(object sender, RoutedEventArgs e) //проверка на данные администратора
        {
            if (Log.Text == "admin1" & Pas.Password == "admin1") //проверка логина и пароля
            {
                MessageBox.Show("Вы успешно вошли");
                NavigationService.Navigate(new adminOsnowa());
            }
            else
                MessageBox.Show("Ошибка");
        }
    }
}
