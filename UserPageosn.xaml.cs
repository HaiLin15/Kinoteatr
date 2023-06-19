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
    /// Логика взаимодействия для UserPageosn.xaml
    /// </summary>
    public partial class UserPageosn : Page
    {
        public UserPageosn()
        {
            InitializeComponent();                                             //вывод фильмов
            MainListView.ItemsSource = user12_dbEntities.GetContext().Film
                .GroupBy(x => x.NameFilm)
                .Select(g => g.FirstOrDefault())
                .ToList();


            var genres = user12_dbEntities.GetContext().Film.Select(f => f.Zanr);
            // Создаем список жанров, разбитых на отдельные элементы
            var genreList = new List<string>();
            foreach (var g in genres)
            {
                genreList.AddRange(g.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries));
            }

            // Добавляем каждый жанр в ComboBox как отдельный элемент
            foreach (var g in genreList.Distinct())
            {
                GenreComboBox.Items.Add(g);
            }

            AgeComboBox.ItemsSource = user12_dbEntities.GetContext().Film.Select(x => x.Ogranichenie).Distinct().ToList();    //получение данных ограничения из бд







        }


        private void MainListView_SelectionChanged(object sender, SelectionChangedEventArgs e)       //при клике пользователь перенаправляется на выбор сеанса
        {
            if (MainListView.SelectedItem != null)
            {
                NavigationService.Navigate(new Seansi(MainListView.SelectedItem as Film));
            }
        }
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)

        {


        }

        private void UpdateMainListView()             //обновление листвью
        {
            var context = user12_dbEntities.GetContext();
            var films = context.Film
                .GroupBy(x => x.NameFilm)
                .Select(g => g.FirstOrDefault())
                .ToList();

            // Фильтруем фильмы по жанру и ограничению
            if (GenreComboBox.SelectedItem != null)
            {
                var selectedGenre = GenreComboBox.SelectedItem.ToString();
                films = films.Where(f => f.Zanr.Contains(selectedGenre)) // Изменяем фильтрацию на поиск по вхождению жанра в список жанров фильма
                    .GroupBy(x => x.NameFilm)
                    .Select(g => g.FirstOrDefault())
                    .ToList();
            }

            if (AgeComboBox.SelectedItem != null)
            {
                var selectedAge = AgeComboBox.SelectedItem.ToString();
                films = films.Where(f => f.Ogranichenie == selectedAge)

                    .GroupBy(x => x.NameFilm)
                    .Select(g => g.FirstOrDefault())
                    .ToList();
            }

            MainListView.ItemsSource = films;
        }

        private void GenreComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)  //при выборе значения жанра листвью обновляется
        {
            if (GenreComboBox.SelectedItem != null)
            {
                SearchByGenre(GenreComboBox.SelectedItem.ToString());
            }
            else
            {
                UpdateMainListView();
            }
        }

        private void SearchByGenre(string genre)
        {
            var context = user12_dbEntities.GetContext();
            var films = context.Film
                .Where(f => f.Zanr.Contains(genre))
                .ToList();

            MainListView.ItemsSource = films;
        }

        private void AgeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)   //при выборе значения ограничения листвью обновляется
        {
            UpdateMainListView();
        }

        private void GenreTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var genres = GenreTextBox.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(x => x.Trim());
            MainListView.ItemsSource = user12_dbEntities.GetContext().Film
                                        .Where(x => genres.Any(g => x.Zanr.Contains(g)))
                                        .GroupBy(x => x.NameFilm)
                                        .Select(g => g.FirstOrDefault())
                                        .ToList();

        }
    }
}
