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
    /// Логика взаимодействия для Zall2.xaml
    /// </summary>
    public partial class Zall2 : Page
    {
        private Film _currentFilm;
        public Zall2(Film film)
        {
            InitializeComponent();
            _currentFilm = film;
            DataContext = film;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Vhod());
        }

        private void Button_Loaded(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.Zal2mesto1 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString(); //преобразование названия кнопки в текст

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.Zal2mesto1 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString(); //преобразование названия кнопки в текст

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.Zal2mesto2 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }

        private void Button1_Loaded(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.Zal2mesto2 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString(); //преобразование названия кнопки в текст

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.Zal2mesto3 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }
        private void Button2_Loaded(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.Zal2mesto3 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString(); //преобразование названия кнопки в текст

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.Zal2mesto4 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }

        private void Button4_Loaded(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.Zal2mesto4 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString(); //преобразование названия кнопки в текст

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.Zal2mesto5 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }

        private void Button5_Loaded(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.Zal2mesto5 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString(); //преобразование названия кнопки в текст

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.Zal2mesto6 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;
        }

        private void Button6_Loaded(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.Zal2mesto6 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString(); //преобразование названия кнопки в текст

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.Zal2mesto7 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;
        }

        private void Button7_Loaded(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.Zal2mesto7 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString(); //преобразование названия кнопки в текст

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.Zal2mesto8 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;
        }

        private void Button8_Loaded(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.Zal2mesto8 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString(); //преобразование названия кнопки в текст

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.Zal2mesto9 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;
        }

        private void Button9_Loaded(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.Zal2mesto9 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString(); //преобразование названия кнопки в текст

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.Zal2mesto10 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;
        }

        private void Button10_Loaded(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.Zal2mesto10 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString(); //преобразование названия кнопки в текст

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.Zal2mesto11 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;
        }

        private void Button11_Loaded(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.Zal2mesto11 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString(); //преобразование названия кнопки в текст

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.Zal2mesto12 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;
        }

        private void Button12_Loaded(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.Zal2mesto12 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString(); //преобразование названия кнопки в текст

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.Zal2mesto13 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;
        }

        private void Button13_Loaded(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.Zal2mesto13 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString(); //преобразование названия кнопки в текст

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.Zal2mesto14 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;
        }

        private void Button14_Loaded(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.Zal2mesto14 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString(); //преобразование названия кнопки в текст

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.Zal2mesto15 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;
        }
        private void Button15_Loaded(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.Zal2mesto15 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString(); //преобразование названия кнопки в текст

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.Zal2mesto16 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;
        }

        private void Button16_Loaded(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.Zal2mesto16 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString(); //преобразование названия кнопки в текст

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.Zal2mesto17 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;
        }

        private void Button17_Loaded(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.Zal2mesto17 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString(); //преобразование названия кнопки в текст

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.Zal2mesto18 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;
        }

        private void Button18_Loaded(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.Zal2mesto18 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString(); //преобразование названия кнопки в текст

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.Zal2mesto19 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;
        }
        private void Button19_Loaded(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.Zal2mesto19 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString(); //преобразование названия кнопки в текст

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.Zal2mesto20 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;
        }

        private void Button20_Loaded(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.Zal2mesto20 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString(); //преобразование названия кнопки в текст

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.Zal2mesto21 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;
        }

        private void Button21_Loaded(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.Zal2mesto21 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString(); //преобразование названия кнопки в текст

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.Zal2mesto22 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;
        }

        private void Button22_Loaded(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.Zal2mesto22 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString(); //преобразование названия кнопки в текст

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.Zal2mesto23 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;
        }

        private void Button23_Loaded(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.Zal2mesto23 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_24(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString(); //преобразование названия кнопки в текст

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.Zal2mesto24 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;
        }

        private void Button24_Loaded(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.Zal2mesto24 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString(); //преобразование названия кнопки в текст

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.Zal2mesto25 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;
        }

        private void Button25_Loaded(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.Zal2mesto25 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }
    }
}
