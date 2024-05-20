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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
        // В обработчике события нажатия кнопки на форме 5
        private void buttonNextForm_Click(object sender, EventArgs e)
        {
            this.Hide(); // Скрываем текущую форму (форму 5)

            Form1 form1 = new Form1();
            form1.Show(); // Показываем форму 1
         
           



        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
