using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checked
{
    class overflowTest
    {
        static short x = 32767;   //Max short value
        static short y = 32767;

        // Using a checkedMethod
        static int Checkedmethod()
        {
            int z = 0;
            try
            {
                z = checked((short)(x + y));
            }
            catch(System.OverflowException e)
            {
                Console.WriteLine(e.ToString());

            }
            return z;
        }

    }
}
