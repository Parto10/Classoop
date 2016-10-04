using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classoop
{
    public class Person
    {
        public int _intAge;
        string _strName;
        string _strFamily;
        public Person(int intAge, string strName, string strFamily)
        {
            this._intAge = intAge;
            this._strName = strName;
            this._strFamily = strFamily;
        }
        public override string ToString()
        {
            return string.Format("I'm: {0}{1} and {2} Years Old", this._strName, this._strFamily, this._intAge);
        }
    }
}
