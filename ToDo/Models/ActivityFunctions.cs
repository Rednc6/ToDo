using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Model
{
    class ActivityFunctions
    {
        public ObservableCollection<Activities> ActivityList { get; set; }

        public ActivityFunctions()
        {
            ActivityList = new ObservableCollection<Activities>();
        }

        public void AddToList(Activities activityToAdd)
        {
            ActivityList.Add(activityToAdd);
        }

        public void RemoveFromList(Activities activityToRemove)
        {
            ActivityList.Remove(activityToRemove);
        }
    }
}
