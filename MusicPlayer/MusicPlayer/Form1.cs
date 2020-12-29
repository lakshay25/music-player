using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    //{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = listBox1.SelectedItem.ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "Audio Files(*.mp3)| *.mp3";
            openFileDialog1.InitialDirectory = "\\music";

            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach (string item in openFileDialog1.FileNames)
                {
                    listBox1.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("You pressed cancel");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count + 1)

            {

                if (listBox1.SelectedIndex < 1) listBox1.SelectedIndex = 1;

                    listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
            }
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.URL = listBox1.SelectedItem.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.Ctlcontrols.next();
            if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
            }
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.URL = listBox1.SelectedItem.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
