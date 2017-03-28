using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Manager
    {
        static Manager instance;

        public static Manager GetInstance()
        {
            if (instance == null) instance = new Manager();

            return instance;
        }

        public List<ManagerObjectInterface> handlers = new List<ManagerObjectInterface>();

        public Manager Request(string request)
        {
            

            return this;
        }
    }
}
