using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
    /// Логика взаимодействия для PageDel.xaml
    /// </summary>
    public partial class PageDel : Page
    {
        public PageDel() //получение контекста
        {
            InitializeComponent();
            MainDataGrid.ItemsSource = user12_dbEntities.GetContext().Film.ToList();


        }

        private void Button_Click(object sender, RoutedEventArgs e) //навигация
        {
            NavigationService.Navigate(new Vhod());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить данные?", "Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Film selectedFilm = MainDataGrid.SelectedItem as Film; //Запись выбраного фильма
                user12_dbEntities.GetContext().Film.Remove(selectedFilm); //удаление
                user12_dbEntities.GetContext().SaveChanges(); //сохранения 
                MainDataGrid.ItemsSource = user12_dbEntities.GetContext().Film.ToList(); //обновление датагрид
                MessageBox.Show("Фильм успешно удален.");


            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Фильмы"; // Имя по умолчанию
            dlg.DefaultExt = ".xlsx"; // Расширение по умолчанию
            dlg.Filter = "Документы Excel (.xlsx)|*.xlsx"; // Фильтр файлов

            // Откройте диалог сохранения файла и получите результат
            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                // Создайте пакет Excel
                using (var package = new OfficeOpenXml.ExcelPackage(new FileInfo(dlg.FileName)))
                {
                    // Создайте лист Excel
                    var worksheet = package.Workbook.Worksheets.Add("Фильмы");

                    // Заполните лист Excel данными из DataGrid
                    for (int i = 0; i < MainDataGrid.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = MainDataGrid.Columns[i].Header;
                    }

                    for (int i = 0; i < MainDataGrid.Items.Count; i++)
                    {
                        for (int j = 0; j < MainDataGrid.Columns.Count; j++)
                        {
                            var cellValue = (MainDataGrid.Columns[j].GetCellContent(MainDataGrid.Items[i]) as TextBlock)?.Text;
                            worksheet.Cells[i + 2, j + 1].Value = cellValue;
                        }
                    }

                    // Сохраните пакет Excel
                    package.Save();
                    var tt = user12_dbEntities.GetContext().Film.ToList();
                    MainDataGrid.SelectedItem = tt;
                    
                    
                        user12_dbEntities.GetContext().Film.RemoveRange(tt);
                        user12_dbEntities.GetContext().SaveChanges();
                    MainDataGrid.ItemsSource = user12_dbEntities.GetContext().Film.ToList();
                }

                MessageBox.Show("Фильмы успешно экспортированы в файл " + dlg.FileName, "Экспорт");
            }





        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
