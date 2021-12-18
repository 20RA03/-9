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
using System.Data;

namespace ПР9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataRow row = res.NewRow();
        Countries country1 = new Countries("Россия", "145975300", "Москва", "Рубль");
        Countries country2 = new Countries("США", "334910050", "Вашингтон", "Доллар");
        Countries country3 = new Countries("Саудовская Аравия", "36121147", "Эр-Рияд", "Саудовский риял");
        Countries country4 = new Countries("Китай", "1442965", "Пекин", "Китайский юань");
        Countries country5 = new Countries("Бразилия", "213317639", "Бразилия", "Бразильский реал");
        public static DataTable res = new DataTable();
        public MainWindow()
        {
            InitializeComponent();
            res.Columns.Add("Страна");
            res.Columns.Add("Народонаселение");
            res.Columns.Add("Столица");
            res.Columns.Add("Денежная единица");
            countriesTable.ItemsSource = res.DefaultView;
            row[0] = country1.CountryName;
            row[1] = country1.Population;
            row[2] = country1.Capital;
            row[3] = country1.MonetaryUnit;
            res.Rows.Add(row);
            row = res.NewRow();
            row[0] = country2.CountryName;
            row[1] = country2.Population;
            row[2] = country2.Capital;
            row[3] = country2.MonetaryUnit;
            res.Rows.Add(row);
            row = res.NewRow();
            row[0] = country3.CountryName;
            row[1] = country3.Population;
            row[2] = country3.Capital;
            row[3] = country3.MonetaryUnit;
            res.Rows.Add(row);
            row = res.NewRow();
            row[0] = country4.CountryName;
            row[1] = country4.Population;
            row[2] = country4.Capital;
            row[3] = country4.MonetaryUnit;
            res.Rows.Add(row);
            row = res.NewRow();
            row[0] = country5.CountryName;
            row[1] = country5.Population;
            row[2] = country5.Capital;
            row[3] = country5.MonetaryUnit;
            res.Rows.Add(row);
            row = res.NewRow();
            countriesTable.ItemsSource = res.DefaultView;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            populationPeople.Text = Convert.ToString(Convert.ToInt32(country1.Population) + Convert.ToInt32(country2.Population) + Convert.ToInt32(country3.Population) + Convert.ToInt32(country4.Population) + Convert.ToInt32(country5.Population));
        }
        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Работу выполнил студент группы ИСП-34 Ржевский А.М. Задание: Заполнить таблицу со списком 5 стран мира с полями: страна, народонаселение, столица, денежная единица.Вывести результат на экран.Вывести общее населениевсех стран.", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}