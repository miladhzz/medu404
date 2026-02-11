using System;
using System.Drawing;
using System.Windows.Forms;

namespace pood3
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    #region
    

    bool isDragging = false;
    bool isDraggingCall = false;
    Point startPoint = new Point(0, 0);
    Point startPointCall = new Point(0, 0);
    private void Form1_Load(object sender, EventArgs e)
    {
      startPoint = pictureBoxCamera.Location;
      startPointCall = pictureBoxCall.Location;
    }

    private void pictureBoxCamera_MouseMove(object sender, MouseEventArgs e)
    {
      if (isDragging)
      {
        pictureBoxCamera.Left += e.X;
        pictureBoxCamera.Top += e.Y;
      }
    }

    private void pictureBoxCamera_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        isDragging = false;
        pictureBoxCamera.Location = startPoint;
      }
    }

    private void pictureBoxCamera_MouseDown(object sender, MouseEventArgs e)
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
    #endregion
    private void timerSignal_Tick(object sender, EventArgs e)
    {
      Random random = new Random();
      int i = random.Next(1, 4);
      pictureBoxSignal.ImageLocation = "img\\signal\\" + i.ToString() + ".png";


      labelHour.Text = DateTime.Now.ToString("HH");
      labelMinute.Text = DateTime.Now.ToString("mm");

      labelDate.Text = DateTime.Now.ToString("ddd, MMMM dd");
    }

    private void label5_Click(object sender, EventArgs e)
    {
        new Form2().ShowDialog();
    }
   
  }
}
