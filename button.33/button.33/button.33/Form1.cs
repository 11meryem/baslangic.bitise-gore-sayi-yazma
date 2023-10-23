using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int basla =Convert.ToInt32(txtBasla.Text);
            int bitis=Convert.ToInt32(txtBitis.Text);
            for(int i=basla; i<=bitis; i++)
            {
               listBox1.Items.Add(i);
            }
        }
    }
}
