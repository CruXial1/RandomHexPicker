using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Globalization;

namespace RandomHexPicker
{
    public partial class Form1 : Form
    {
        List<string> values = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f" };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> HexColor = new List<string>();

            var random = values.Shuffle().Take(6);

            foreach (var item in random)
            {
                HexColor.Add(item);
            }

            string output = String.Join("", HexColor.ToArray());

            textBox1.Text = $"#{output}";

            int argb = Int32.Parse(output.Replace("#", ""), NumberStyles.HexNumber);
            Color clr = Color.FromArgb(argb);

            textBox1.ForeColor = clr;
        }
    }
}
