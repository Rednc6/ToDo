using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Model;

namespace ToDo.ModelView
{
    class NewToDoViewModel : INotifyPropertyChanged
    {
        // RelayCommands

        // Props
        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private String _information;
        public  String Information
        {
            get { return _information; }
            set { _information = value; }
        }

        private String _location;   
        public String Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public Activities Activities { get; set; }



        // ctor
        public NewToDoViewModel()
        {
            
        }

        // PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

    }
}
