﻿using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Логика взаимодействия для PageGostFilm.xaml
    /// </summary>
    public partial class PageGostFilm : Page
    {
        private Film _currentFilm;
        public PageGostFilm(Film film)
        {
            InitializeComponent();
            _currentFilm = film;
            DataContext = film;

            datePicker.SelectedDateChanged += DatePicker_SelectedDateChanged; // добавляем обработчик события на DatePicker
            UpdateSeansiList(DateTime.Today); // обновляем список сегодняшним днем


            
        






        }

        



        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime selectedDate = datePicker.SelectedDate ?? DateTime.Today; // выбранная пользователем дата или сегодняшняя дата
            UpdateSeansiList(selectedDate); // обновляем список с выбранной датой
        }

        private void UpdateSeansiList(DateTime selectedDate)
        {
            MainListView.ItemsSource = user12_dbEntities.GetContext().Film
                .Where(f => f.NameFilm == _currentFilm.NameFilm && f.Date_seans == selectedDate) // фильтруем по названию фильма и выбранной дате
                .OrderBy(f => f.NameFilm) // сортируем по названию фильма
                .ToList();


            
        }
      

        




        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)

        {
            



        }
        private void MainListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            




        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
