using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                Opacity += 0.1d;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
