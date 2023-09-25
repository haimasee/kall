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
    /// Логика взаимодействия для SelectedElement.xaml
    /// </summary>
    public partial class SelectedElement : UserControl
    {
        public SelectedClass SelectedClass { get; private set; }
        public SelectedElement(SelectedClass selectedclass)
        {
            SelectedClass = selectedclass;
            InitializeComponent();

            Textblock.Text = selectedclass.name.ToString();
            image.Source = new BitmapImage(new Uri(selectedclass.img, UriKind.RelativeOrAbsolute));
            Checkbox.IsChecked = selectedclass.isSelected;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            SelectedClass.isSelected = (bool)Checkbox.IsChecked;
        }
    }
}
