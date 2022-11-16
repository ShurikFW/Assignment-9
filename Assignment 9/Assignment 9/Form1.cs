using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<char, int> Dic = new Dictionary<char, int>();
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (!Dic.ContainsKey(textBox1.Text[i]))
                    Dic.Add(textBox1.Text[i], 1);
                else
                    Dic[textBox1.Text[i]]++;
            }
            var max = Dic.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            MessageBox.Show(max.ToString());
        }
    }
}
