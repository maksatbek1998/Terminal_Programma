using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glavnyi_Monitor.Models
{
    public class Direction
    {
        private int numberID { get; set; }
        private int NumberID
        {
            get => numberID;
            set
            {
                numberID = value;
            }
        }
        private int name { get; set; }
        private int Name
        {
            get => name;
            set
            {
                name = value;
            }
        }
    }
}
