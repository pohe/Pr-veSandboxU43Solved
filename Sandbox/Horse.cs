using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Horse: Animal
    {
        private bool _CanTrot;

        public bool CanTrot
        {
            get { return _CanTrot; }
            set { _CanTrot = value; }
        }

        public Horse(int age, string typeName, string sound, bool canTrot) : base(age, typeName, sound)
        {
            _CanTrot = canTrot;
        }

        public override string AllInformation()
        {
            return base.AllInformation() + " Can trot " + _CanTrot;
        }
    }
}
