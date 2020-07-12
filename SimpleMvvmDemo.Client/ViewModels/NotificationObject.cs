using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace SimpleMvvmDemo.Client.ViewModels
{
    class NotificationObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                System.Diagnostics.Debug.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                //this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                System.Diagnostics.Debug.WriteLine("****************************");
            }
        }
    }
}
