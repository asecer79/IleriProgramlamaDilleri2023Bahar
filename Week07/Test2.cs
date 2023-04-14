using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week07
{
    //internal.....

    class Test2
    {
        public void M()
        {
            Test t = new Test();
           // t.age = 15; //err, outside of class
            t.SetAge(25);
            t.name = "Hasan";
        }
       
    }

}
