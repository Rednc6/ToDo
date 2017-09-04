using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Model
{
    class ActivityFunctions
    {
        public List<Activities> ActivityList { get; set; }

        public ActivityFunctions()
        {
            ActivityList = new List<Activities>();
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
