using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Manager manager = Manager.GetInstance();
            manager.handlers.Add(new DigitHandler());

            DisplayManager.GetInstace();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Manager.GetInstance().Request("0");
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            DisplayManager.GetInstace().textBox.Text = "Najechales";
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            DisplayManager.GetInstace().textBox.Text = "Papa";
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
