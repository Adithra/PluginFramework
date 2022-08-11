using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnicalExam_MoresandTechnologies;

namespace TestApp
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Test test = new Test();
            pictureBox1.Image = test.Byte_Array_To_Image(File.ReadAllBytes(@"../../Test/Test.txt"));

            //foreach (var plugin in test.Test_API())
            //{
                pictureBox2.Image = test.Test_API()[0].Image;
            //}
        }

    }
}
