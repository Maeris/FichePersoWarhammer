using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichePerso.ViewModel
{
    public class MainPageViewModel : ViewModelBase
    {
        private ObservableCollection<string> _testItems;
        public ObservableCollection<string> TestItems
        {
            get { return _testItems; }
            set
            {
                _testItems = value;
                RaisePropertyChanged("TestItems");
            }
        }

        public MainPageViewModel()
        {
            List<string> test = new List<string>();
            test.Add("coucou");
            test.Add("test");
            test.Add("coucou");
            test.Add("test");
            test.Add("coucou");
            test.Add("test");
            test.Add("coucou");
            test.Add("test");
            TestItems = new ObservableCollection<string>(test);
        }

    }
}
