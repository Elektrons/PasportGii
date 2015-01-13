using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasportStudentGii
{
    public partial class MainForm : Form
    {
        EnterPass _ePass;
        public MainForm(EnterPass ePass)
        {
            InitializeComponent();
            _ePass = ePass;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _ePass.Close();
        }


    }
}
