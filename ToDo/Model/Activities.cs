using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Model
{
    class Activities
    {
        public DateTime Date { get; set; }
        public String Location { get; set; }
        public String Information { get; set; }

        public Activities(DateTime date, String location, String Information)
        {
            this.Date = date;
            this.Location = location;
            this.Information = Information;
        }
    }
}
