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
    /// Логика взаимодействия для SelectedPage.xaml
    /// </summary>
    public partial class SelectedPage : Page
    {
        List<SelectedElement>  SelectedObjects = new List<SelectedElement>();
        List<SelectedItemsIn1Day> selecteditems = new List<SelectedItemsIn1Day>();
        //List<SelectedItemsIn1Day> selecteditems = DeserANDSer.Deserialization<SelectedItemsIn1Day>();

        public string DayMonthYear;
        public SelectedPage()
        {
            InitializeComponent();
            string a = Convert.ToString(MainPage.month.Month);
            string b = Convert.ToString(MainPage.month.Year);
            DayMonthYear = Date.dayDay + '.' + a + '.'+b;
            List<SelectedClass> languages = new List<SelectedClass> { new SelectedClass("C#", "/sharp.png"), new SelectedClass("Python", "/python.png"), new SelectedClass("HTML", "/HTML.png") };
            foreach (var lang in languages)
            {
                var userGame = new SelectedElement(lang);
                SelectedObjects.Add(userGame);
            }
            SelectedList.ItemsSource = SelectedObjects;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            List<SelectedClass> elem = new List<SelectedClass>();
            foreach (var obj in SelectedObjects)
            {
                elem.Add(obj.SelectedClass);
            }
            selecteditems.Add(new SelectedItemsIn1Day(new DateTime(Convert.ToInt32(DayMonthYear.Split('.')[2]), Convert.ToInt32(DayMonthYear.Split('.')[1]),Convert.ToInt32(DayMonthYear.Split('.')[0]),0,0,0 ), elem));
           
            DeserANDSer.Serialization(selecteditems);
            (Application.Current.MainWindow as MainWindow).FirstFrame.Content = new MainPage();
        }
        

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).FirstFrame.Content = new MainPage();
        }

        private void SelectedList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
