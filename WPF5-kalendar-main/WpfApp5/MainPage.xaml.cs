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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        
        public static DateTime month;
        public static DateTime currentDATE = DateTime.Now;
        public MainPage()
        {
            InitializeComponent();
            month = DateTime.Now;
            day.Text = month.ToString("MM.yyyy");
            schet(DateTime.DaysInMonth(month.Year, month.Month));
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            month = month.AddMonths(1);
            day.Text = month.ToString("MM.yyyy");

            schet(DateTime.DaysInMonth(month.Year, month.Month));

            //UpdateWindow();
        }

        private void schet(int month1)
        {
            wrap.Children.Clear();
            List<Date> kalendars = new List<Date>();
            for (int i = 1; i <= month1; i++)
            {
                Date a = new Date();
                a.dayButton.Content = i.ToString();
                wrap.Children.Add(a);
                //list.ItemsSource = kalendars;
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            month = month.AddMonths(-1);
            day.Text = month.ToString("MM.yyyy");

            schet(DateTime.DaysInMonth(month.Year, month.Month));


        }

        private void datepicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (datepicker.SelectedDate != null)
            {
                month = datepicker.SelectedDate.Value;
                day.Text = month.ToString("MM.yyyy");

                schet(DateTime.DaysInMonth(month.Year, month.Month));
            }
        }
    }
}
