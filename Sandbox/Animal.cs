using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Animal
    {
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private string _typeName;

        public string TypeName
        {
            get { return _typeName; }
            set { _typeName = value; }
        }

        private string _sound;

        public string Sound
        {
            get { return _sound; }
            set { _sound = value; }
        }

        

        public Animal(int age, string typeName, string sound)
        {
            _age = age;
            _typeName = typeName;
            _sound = sound;
        }

        public virtual string AllInformation()
        {
            return " Type name " + _typeName + " Alder " + _age + " sound " + _sound;
        }

    }
}
