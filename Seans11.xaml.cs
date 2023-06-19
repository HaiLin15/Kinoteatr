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
    /// Логика взаимодействия для Seans11.xaml
    /// </summary>
    public partial class Seans11 : Page
    {

        private Film _currentFilm;
        public Seans11(Film film) //получение значений выбраного фильма с прошлой страницы
        {
            InitializeComponent(); //создание контекстов
            _currentFilm = film;
            DataContext = film;

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
                if ( film.mesto1 == value)
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
                    film.mesto1 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto2 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }
        private void Button_Loaded1(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto2 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto3 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }

        private void Button_Loaded3(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto3 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Vhod());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto4 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }
        private void Button_Loaded4(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto4 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto5 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }
        private void Button_Loaded5(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto5 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto6 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }
        private void Button_Loaded6(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto6 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto7 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }

        private void Button_Loaded7(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto7 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto8 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }

        private void Button_Loaded8(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto8 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto9 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }

        private void Button_Loaded9(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto9 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto10 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }

        private void Button_Loaded10(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto10 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto11 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }

        private void Button_Loaded11(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto11 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto12 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }

        private void Button_Loaded12(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto12 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto13 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }
        private void Button_Loaded13(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto13 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto14 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }
        private void Button_Loaded14(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto14 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto15 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }

        private void Button_Loaded15(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto15 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto16 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }
        private void Button_Loaded16(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto16 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto17 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }

        private void Button_Loaded17(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto17 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto18 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }

        private void Button_Loaded18(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto18 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto19 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }

        private void Button_Loaded19(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto19 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto20 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }

        private void Button_Loaded20(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto20 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto21 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }

        private void Button_Loaded21(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto21 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto22 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }

        private void Button_Loaded22(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto22 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto23 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }

        private void Button_Loaded23(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto23 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_24(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto24 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }
        private void Button_Loaded24(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto24 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto25 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }

        private void Button_Loaded25(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto25 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_26(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto26 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }

        private void Button_Loaded26(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto26 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_27(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto27 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }

        private void Button_Loaded27(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto27 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_28(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto28 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }

        private void Button_Loaded28(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto28 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_29(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto29 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;

        }
        private void Button_Loaded29(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto29 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void Button_Click_30(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Сохранить значение в базу данных
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film != null)
                {
                    film.mesto30 = value;
                    db.SaveChanges();
                }
            }

            // Сделать кнопку неактивной
            button.IsEnabled = false;


        }

        private void Button_Loaded30(object sender, RoutedEventArgs e)
        {
            // Получить значение кнопки
            var button = (Button)sender;
            var value = button.Content.ToString();

            // Проверить значение в базе данных и сделать кнопку неактивной, если значение уже сохранено
            using (var db = new user12_dbEntities())
            {
                var film = db.Film.FirstOrDefault(f => f.ID_Film == _currentFilm.ID_Film);
                if (film.mesto30 == value)
                {
                    button.IsEnabled = false;
                }
            }
        }
    }
}
