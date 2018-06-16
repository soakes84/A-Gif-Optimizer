using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GifOpto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "GIF Files|*.gif";
            openFileDialog1.Title = "Select a GIF File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var fs = new System.IO.FileStream(openFileDialog1.FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                {
                    var ms = new System.IO.MemoryStream();
                    fs.CopyTo(ms);
                    ms.Position = 0;

                    if (pictureBoxSource.Image != null)
                        pictureBoxSource.Image.Dispose();

                    pictureBoxSource.Image = Image.FromStream(ms);
                }
            }
        }
    }
}
