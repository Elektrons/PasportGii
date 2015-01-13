using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PasportStudentGii
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
            string line;
            System.IO.StreamReader file =
            new System.IO.StreamReader(@"c:\test.txt");
            line = file.ReadLine();
            file.Close();
            Application.Run(new EnterPass(line));
        } 
    }
}
