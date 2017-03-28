
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class DisplayManager
    {
        static DisplayManager instance;

        public static DisplayManager GetInstace()
        {
            if (instance == null) instance = new DisplayManager();

            return instance;
        }        

        DisplayManager()
        {
            textBox = Form1.textBox1;
        }

        public double memoryValue;
        public double currentValue {
            get {
                return double.Parse(textBox.Text);
            }

            set
            {
                textBox.Text = value.ToString();
            }
        }

        public TextBox textBox;


    }
}
