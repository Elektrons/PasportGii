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
    public partial class EnterPass : Form
    {
        string _pass;
        public EnterPass(string pass)
        {
            InitializeComponent();
            _pass = pass;
        }

        public void Verification()
        {
            if (_pass == textBox1.Text)
            {
                this.Visible = false;
                MainForm _mainF = new MainForm(this);
                _mainF.Show();
            }
            else {
                MessageBox.Show("Вспомни пароль, Мудак!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Verification();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyData)
                Verification();
        }
    }
}
