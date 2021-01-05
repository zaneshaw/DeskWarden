using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskWarden
{
    public class settings
    {
        private bool _state1;
        public bool state1
        {
            get { return _state1; }
            set { _state1 = value; }
        }

        private int _interval1;
        public int interval1
        {
            get { return _interval1; }
            set { _interval1 = value; }
        }
    }
}
