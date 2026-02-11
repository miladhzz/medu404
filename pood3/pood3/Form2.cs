using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pood3
{
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();
    }

    private void label2_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      Random random = new Random();
      int i = random.Next(1, 4);
      pictureBoxSignal.ImageLocation = "img\\signal\\" + i.ToString() + ".png";

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox4_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox5_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox6_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox7_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox8_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox9_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox0_Click(object sender, EventArgs e)
    {

    }

    private void pictureBoxOk_Click(object sender, EventArgs e)
    {

    }

    private void pictureBoxRemove_Click(object sender, EventArgs e)
    {

    }
  }
}
