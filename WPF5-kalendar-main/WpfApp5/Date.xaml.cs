using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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
    /// Логика взаимодействия для Date.xaml
    /// </summary>
    public partial class Date : UserControl
    {
        //public Frame FirstFrame;
        public static string dayDay;
        public Date()
        {
            //this.FirstFrame = FirstFrame;
            InitializeComponent();
        }

        private void DAY_Click(object sender, RoutedEventArgs e)
        {
            dayDay = dayButton.Content.ToString();
            (Application.Current.MainWindow as MainWindow).FirstFrame.Content = new SelectedPage();
            //FirstFrame.Content = new SelectedPage();
        }
    }
}
