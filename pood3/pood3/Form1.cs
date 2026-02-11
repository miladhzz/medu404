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
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();

      pictureBoxCamera.MouseDown += pictureBox1_MouseDown;
      pictureBoxCamera.MouseMove += pictureBox1_MouseMove;
      pictureBoxCamera.MouseUp += pictureBox1_MouseUp; 
      
      pictureBoxCall.MouseDown += pictureBoxCall_MouseDown;
      pictureBoxCall.MouseMove += pictureBoxCall_MouseMove;
      pictureBoxCall.MouseUp += pictureBoxCall_MouseUp;

      startPoint = pictureBoxCamera.Location;
      startPointCall = pictureBoxCall.Location;
    }

    private bool isDragging = false;
    private bool isDraggingCall = false;
    private Point startPoint = new Point(0, 0);
    private Point startPointCall = new Point(0, 0);


    private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
      if (isDragging)
      {
        pictureBoxCamera.Left += e.X;
        pictureBoxCamera.Top += e.Y;

      }
    }

    private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        isDragging = false;
        pictureBoxCamera.Location = startPoint;
      }
    }

    private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        isDragging = true;
      }


    }
      private void pictureBoxCall_MouseMove(object sender, MouseEventArgs e)
    {
      if (isDraggingCall)
      {
        pictureBoxCall.Left += e.X;
        pictureBoxCall.Top += e.Y;

      }
    }

    private void pictureBoxCall_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        isDraggingCall = false;
        pictureBoxCall.Location = startPointCall;
      }
    }

    private void pictureBoxCall_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        isDraggingCall = true;
      }
    }

    private void timerSignal_Tick(object sender, EventArgs e)
    {
      Random random = new Random();
      int i = random.Next(1, 4);
      pictureBoxSignal.ImageLocation = "img\\signal\\" + i.ToString() + ".png";


      labelHour.Text = DateTime.Now.ToString("HH");
      labelMinute.Text = DateTime.Now.ToString("mm");

      labelDate.Text = DateTime.Now.ToString("ddd, MMMM dd");
    }
  }
}
