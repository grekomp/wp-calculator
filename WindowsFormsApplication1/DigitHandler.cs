using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class DigitHandler : ManagerObjectInterface
    {
        public bool Serve(string request)
        {
            switch(request)
            {
                case "0":

                    break;
                default:
                    return false;
            }

            return true;
        }
    }
}
