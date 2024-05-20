using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form3 first = new Form3();
            DateTime end1 = DateTime.Now + TimeSpan.FromSeconds(1);
            first.Show();
            while (end1 > DateTime.Now)
            {
                Application.DoEvents();
            }
            Form4 second = new Form4();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(4);
            second.Show();
            while (end > DateTime.Now)
            {
                Application.DoEvents();
            }

            {
                Application.DoEvents();
                first.Close();
                first.Dispose();
                second.Close();
                second.Dispose();
                Application.Run(new Start());
            
             
      
                

            }
        }
    }
}
