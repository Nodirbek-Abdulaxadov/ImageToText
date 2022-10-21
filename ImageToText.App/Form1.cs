using ImageToText.Lib;
using System.Security.Cryptography;

namespace ImageToText.App
{
    public partial class ImageToText : Form
    {
        public ImageToText()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ofd.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|jpeg files(*.jpeg)|*.jpeg|All Files(*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.ImageLocation = ofd.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ITT.Convert(ofd.FileName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            pictureBox1.ImageLocation = "";
            richTextBox1.Text = "";
        }
    }
}