using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean b = true;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(b)
            {
                menuStrip1.Dock = DockStyle.Left;
                b = false;
                toolStripMenuItem1.Image = Image.FromFile(@"D:\Workspace\LTTQ\Bài tập lớn\Image\gym icons and images\Name-48-50px\img3.jpg");
            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                b = true;
                toolStripMenuItem1.Image = Image.FromFile(@"D:\Workspace\LTTQ\Bài tập lớn\Image\gym icons and images\Name-48-50px\img2.jpg");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripMenuItem1.Image = Image.FromFile(@"D:\Workspace\LTTQ\Bài tập lớn\Image\gym icons and images\Name-48-50px\img3.jpg");
        }
    }
}
