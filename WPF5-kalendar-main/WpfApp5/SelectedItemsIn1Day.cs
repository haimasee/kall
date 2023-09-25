using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace WpfApp5
{
    internal class SelectedItemsIn1Day
    {
        public DateTime dateof { get; private set; }
        public List<SelectedClass> selecteditemsinDay { get; private set; }
        public SelectedItemsIn1Day(DateTime dateof, List<SelectedClass> selecteditemsinDay)
        {
            this.dateof = dateof;
            this.selecteditemsinDay = selecteditemsinDay;
        }
        //Подправить
    }
}
