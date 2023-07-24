using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    //Creamos una clase tipo abstracta
    public abstract class ViewModelBase : INotifyPropertyChanging, INotifyPropertyChanged
    {
        public event PropertyChangingEventHandler? PropertyChanging;
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChaging([CallerMemberName] string propetyName = "") 
        {
            PropertyChanging(this, new PropertyChangingEventArgs(propetyName));

        }
        protected void OnPropertyChanged([CallerMemberName]string propetyName = "") 
        {
            if (PropertyChanged != null) 
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propetyName));
            }
        
        }
    }
}
