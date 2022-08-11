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

        //In this method commented lines demostare how to call multiple plugings. commented due to no actual funtion for thoes plugins only resize has coded function.
        private void Form1_Load(object sender, EventArgs e)
        {
            Test test = new Test();
            pictureBox1.Image =  pictureBox3.Image = test.Byte_Array_To_Image(File.ReadAllBytes(@"../../Test/Test.txt"));

            pictureBox2.Image = test.Test_API(pictureBox1.Image)[0].Image;
            //pictureBox2.Image = test.Test_API(pictureBox1.Image)[1].Image;          

            var imageLists = test.Test_API_MI(new List<Image> { pictureBox1.Image, pictureBox3.Image });
            pictureBox2.Image = imageLists[0][0].Image;
            //pictureBox2.Image = imageLists[0][1].Image;
            pictureBox4.Image = imageLists[1][0].Image;
            //pictureBox4.Image = imageLists[1][1].Image;

        }

    }
}
