using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Whale : Animal
    {
        private bool _HaveFlippers;

        public bool HaveFlippers
        {
            get { return _HaveFlippers; }
            set { _HaveFlippers = value; }
        }

        public Whale(int age, string typeName, string sound, bool haveFlippers) : base(age, typeName, sound)
        {
            _HaveFlippers = haveFlippers;
        }

        public override string AllInformation()
        {
            return base.AllInformation()+  " have flippers " + _HaveFlippers;
        }
    }
}
