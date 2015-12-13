using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FichePerso.Model
{
    public class BindingNotification : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected bool NotifyPropertyChanged<T>(ref T variable, T value, [CallerMemberName] string propertyName = default(string))
        {
            if (object.Equals(variable, value))
            {
                return false;
            }

            variable = value;
            NotifyPropertyChanged(propertyName);
            return true;
        }
    }
}
