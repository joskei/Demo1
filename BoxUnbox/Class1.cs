using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace BoxUnbox
{
    public class Class1
    {
        public void TestBoxUnbox()
        {
            var i = 2;
            object o = i;

            var z = (int)o;
        }
        
        
    }
}
