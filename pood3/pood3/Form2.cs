using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pood3
{
  public partial class Form2 : Form
  {
    private ArrayList enteredPassword = new ArrayList();

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
      enteredPassword.Add(1);
      labelPass.Text += "●";
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
      enteredPassword.Add(2);
      labelPass.Text += "●";
    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
      enteredPassword.Add(3);
      labelPass.Text += "●";
    }

    private void pictureBox4_Click(object sender, EventArgs e)
    {
      enteredPassword.Add(4);
      labelPass.Text += "●";
    }

    private void pictureBox5_Click(object sender, EventArgs e)
    {
      enteredPassword.Add(5);
      labelPass.Text += "●";
    }

    private void pictureBox6_Click(object sender, EventArgs e)
    {
      enteredPassword.Add(6);
      labelPass.Text += "●";
    }

    private void pictureBox7_Click(object sender, EventArgs e)
    {
      enteredPassword.Add(7);
      labelPass.Text += "●";
    }

    private void pictureBox8_Click(object sender, EventArgs e)
    {
      enteredPassword.Add(8);
      labelPass.Text += "●";
    }

    private void pictureBox9_Click(object sender, EventArgs e)
    {
      enteredPassword.Add(9);
      labelPass.Text += "●";
    }

    private void pictureBox0_Click(object sender, EventArgs e)
    {
      enteredPassword.Add(0);
      labelPass.Text += "●";
    }

    private void pictureBoxOk_Click(object sender, EventArgs e)
    {
      string password = "";
      foreach (object obj in enteredPassword)
      {
        password += obj.ToString();
      }

      if (password == "1111")
      {
        MessageBox.Show("خوش آمدید","ورود موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        labelMessage.Text = "Incorrect PIN entered";
      }
    }

    private void pictureBoxRemove_Click(object sender, EventArgs e)
    {
      if (enteredPassword.Count > 0)
      {
        enteredPassword.RemoveAt(enteredPassword.Count - 1);

        if (labelPass.Text.Length > 0)
          labelPass.Text = labelPass.Text.Substring(0, labelPass.Text.Length - 1);
      }
    }
  }
}
