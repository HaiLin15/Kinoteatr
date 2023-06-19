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
using System.Text.RegularExpressions;
using Microsoft.Win32;
using System.IO;
using Microsoft.IdentityModel.Protocols;
using System.Windows.Media.Animation;


namespace Kinoteatr
{
    /// <summary>
    /// Логика взаимодействия для adminOsnowa.xaml
    /// </summary>
    public partial class adminOsnowa : Page
    {
        DataBase dataBase = new DataBase();


        public adminOsnowa()
        {
            //добавление ограничения
            InitializeComponent();
            Ogranichenie.Items.Add("0+");
            Ogranichenie.Items.Add("6+");
            Ogranichenie.Items.Add("12+");
            Ogranichenie.Items.Add("16+");
            Ogranichenie.Items.Add("18+");

            


            //Добавление страны
            Count.Items.Add("США");
            Count.Items.Add("Россия");
            Count.Items.Add("Франция");
            Count.Items.Add("Германия");
            Count.Items.Add("Великобритания");
            Count.Items.Add("Япония");
            Count.Items.Add("Испания");

            Zanr1.Items.Add("Боевик ");
            Zanr1.Items.Add("Комедия ");
            Zanr1.Items.Add("Драма ");
            Zanr1.Items.Add("Мелодрама ");
            Zanr1.Items.Add("Триллер ");
            Zanr1.Items.Add("Детектив ");
            Zanr1.Items.Add("Фентези ");
            Zanr1.Items.Add("Криминал ");
            Zanr1.Items.Add("Фантастика ");
            Zanr1.Items.Add("Военный ");

            Zanr2.Items.Add("Боевик ");
            Zanr2.Items.Add("Комедия ");
            Zanr2.Items.Add("Драма ");
            Zanr2.Items.Add("Мелодрама ");
            Zanr2.Items.Add("Триллер ");
            Zanr2.Items.Add("Детектив ");
            Zanr2.Items.Add("Фентези ");
            Zanr2.Items.Add("Криминал ");
            Zanr2.Items.Add("Фантастика ");
            Zanr2.Items.Add("Военный ");

            Zanr3.Items.Add("Боевик ");
            Zanr3.Items.Add("Комедия ");
            Zanr3.Items.Add("Драма ");
            Zanr3.Items.Add("Мелодрама ");
            Zanr3.Items.Add("Триллер ");
            Zanr3.Items.Add("Детектив ");
            Zanr3.Items.Add("Фентези ");
            Zanr3.Items.Add("Криминал");
            Zanr3.Items.Add("Фантастика ");
            Zanr3.Items.Add("Военный ");
        }

        public void Button_Click(object sender, RoutedEventArgs e)                                     // открытие диалогового окна с выбором фото
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".jpg"; 
            dlg.Filter = "Images (.jpg)|*.jpg";                //ограничение на файлы только jpg

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                string filename = dlg.FileName;
                BitmapImage image = new BitmapImage(new System.Uri(filename));      //преобразование фото 
                image1.Source = image;
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

            //получение значений 
            string nazvanie = Nazvanie.Text;
            string zanr = Zanr1.Text + Zanr2.Text + Zanr3.Text;
            string ogranichenie = Ogranichenie.Text;
            string opisanie = OpisanieF.Text;
            //получение даты
            DateTime selectedDate = DateGr.SelectedDate ?? DateTime.Now;
            DateTime time = Times.SelectedTime ?? DateTime.Now;
            DateTime TimeFilm1 = timeFilm.SelectedTime ?? DateTime.Now;
            string Strana = Count.Text;
            string hall;
            double timeee = TimeFilm1.Hour;
            double timeee1 = TimeFilm1.Minute;









            DateTime startTime = time;
            DateTime endTime = new DateTime(time.Year, time.Month, time.Day, 22, 0, 0); // конечное время - 22:00

            while (startTime < endTime)
            {
                DateTime newTime = startTime.AddHours(timeee).AddMinutes(timeee1);
                if (newTime >= endTime) // если следующее время больше или равно 22:00, выходим из цикла
                {

                    byte[] photoBytes1;
                    JpegBitmapEncoder encoder1 = new JpegBitmapEncoder();
                    encoder1.Frames.Add(BitmapFrame.Create((BitmapImage)image1.Source));
                    using (MemoryStream ms = new MemoryStream()) //преобразование
                    {
                        encoder1.Save(ms);
                        photoBytes1 = ms.ToArray();
                    }
                    dataBase.openConnection();

                    if (hall1.IsChecked == true)
                    {
                        hall = "Зал1";
                    }
                    else if (hall2.IsChecked == true)
                    {
                        hall = "Зал2";
                    }
                    else
                    {
                        hall = "Зал1";
                    }



                    //запрос на вставку значений
                    string querystring1 = $"insert into Film(NameFilm, Photo, Zanr, Ogranichenie, Opisanie,Date_seans, time_seans, Time_Film, Country, Zal) values('{nazvanie}', @Photo, '{zanr}', '{ogranichenie}', '{opisanie}', '{selectedDate}','{startTime}', '{TimeFilm1}', '{Strana}', '{hall}')";
                    //вставка фото
                    SqlCommand command1 = new SqlCommand(querystring1, dataBase.getConnection());
                    command1.Parameters.AddWithValue("@Photo", photoBytes1);


                    startTime = newTime; // обновляем время
                    if (command1.ExecuteNonQuery() == 1) //проверка на ошибки
                    {
                        MessageBox.Show("Фильм добавлен");



                    }
                    else
                    {
                        MessageBox.Show("Ошибка!");
                    }
                    dataBase.closeConnection();


                    break;

                }

                    

                // преобразуем картинку в массив байтов
                byte[] photoBytes;
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create((BitmapImage)image1.Source));
                using (MemoryStream ms = new MemoryStream()) //преобразование
                {
                    encoder.Save(ms);
                    photoBytes = ms.ToArray();
                }
                dataBase.openConnection();

                if (hall1.IsChecked == true)
                {
                    hall = "Зал1";
                }
                else if (hall2.IsChecked == true)
                {
                    hall = "Зал2";
                }
                else
                {
                    hall = "Зал1";
                }



                //запрос на вставку значений
                string querystring = $"insert into Film(NameFilm, Photo, Zanr, Ogranichenie, Opisanie,Date_seans, time_seans, Time_Film, Country, Zal) values('{nazvanie}', @Photo, '{zanr}', '{ogranichenie}', '{opisanie}', '{selectedDate}','{startTime}', '{TimeFilm1}', '{Strana}', '{hall}')";
                //вставка фото
                SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
                command.Parameters.AddWithValue("@Photo", photoBytes);


                startTime = newTime; // обновляем время
                if (command.ExecuteNonQuery() == 1) //проверка на ошибки
                {
                    MessageBox.Show("Фильм добавлен");



                }
                else
                {
                    MessageBox.Show("Ошибка!");
                }
                dataBase.closeConnection();

                
            }   

        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //навигация
        {
            NavigationService.Navigate(new PageDel());
        }

        private void ZanrFilm_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
