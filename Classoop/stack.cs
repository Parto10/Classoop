using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace Classoop
{
    public class stack
    {
        public int intIndex = -1;
        ArrayList List = new ArrayList();
        public void push(int intData)
        {
            List.Add(intData);
            intIndex++;
        }
        public int pop()
        {
            if (intIndex >= 0)
            {
                int intData = (int)List[intIndex];
                List.RemoveAt(intIndex);
                intIndex--;
                return intData;
            }
            else
            {
                return (-1);
            }
        }

    }
}
