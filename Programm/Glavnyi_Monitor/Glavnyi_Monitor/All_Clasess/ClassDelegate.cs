using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glavnyi_Monitor.All_Clasess
{
   public class ClassDelegate
    {
        public  delegate void SoundDelegate();
        public event SoundDelegate _del;
    }
}
