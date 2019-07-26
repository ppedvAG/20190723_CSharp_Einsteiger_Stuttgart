using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Einfacher Klick!!!");
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Button3_DoppelKlick(object sender, EventArgs e)
        {
            MessageBox.Show("Doppelklick!!! OHNE MAUS");
        }
        private void Button3_MausDoppelKlick(object sender, EventArgs e)
        {
            MessageBox.Show("Doppelklick!!! MIT MAUS");
        }
    }
}
