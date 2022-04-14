using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using AForge.Video.DirectShow;
using iTextSharp.text.pdf;
using ZXing;
using MediaBazaar.classes;
using MediaBazaar;

namespace CheckIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice device;
        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo fi in this.filterInfoCollection)
            {
                cbDevices.Items.Add(fi.Name);
            }
            cbDevices.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            device = new VideoCaptureDevice(filterInfoCollection[cbDevices.SelectedIndex].MonikerString);
            device.NewFrame += Device_NewFrame;
            device.Start();
            timer1.Start();
        }

        private void Device_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (device.IsRunning)
            {
                device.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                timer1.Stop();
                if (result != null)
                {
                    tbEmployeeEmail.Text = result.ToString();
                }
            }

            string email = tbEmployeeEmail.Text;
            foreach (Shift s in DatabaseHelper.GetAllShifts())
            {
                if (s.Email == email)
                {
                    if (s.Date == DateTime.Today)
                    {
                        if (s.Sh == "morning")
                        {
                            if (DateTime.Now.Hour == 8 && DateTime.Now.Minute < 30)
                            {
                                //earlier than 8:30; can't check in yet
                                MessageBox.Show("It's too early to check in!");
                            }
                            else if ((DateTime.Now.Hour == 8 && DateTime.Now.Minute >= 30 && DateTime.Now.Minute <= 59) || (DateTime.Now.Hour == 9 && DateTime.Now.Minute == 0))
                            {
                                //between 8:30 and 9:00; check in employee, status ON TIME
                                DatabaseHelper.UpdateExistingShift(s.Id, s.Name, s.Email, s.Date, s.Sh, "ON TIME");
                                MessageBox.Show("You were successfully checked in! You are marked as ON TIME.");
                            }
                            else if (DateTime.Now.Hour == 9 && DateTime.Now.Minute >= 1  && DateTime.Now.Minute <= 30)
                            {
                                //between 9:01 and 9:30; check in employee, status LATE
                                DatabaseHelper.UpdateExistingShift(s.Id, s.Name, s.Email, s.Date, s.Sh, "LATE");
                                MessageBox.Show("You were successfully checked in! You are marked as LATE.");
                            }
                            else
                            {
                                //after 9:30; can't check in employee anymore
                                MessageBox.Show("Your shift started a while ago, you can't check in anymore! You are marked as ABSENT");
                                DatabaseHelper.UpdateExistingShift(s.Id, s.Name, s.Email, s.Date, s.Sh, "ABSENT");
                            }
                        }
                        else if (s.Sh == "afternoon")
                        {
                            if (DateTime.Now.Hour == 11 && DateTime.Now.Minute < 30)
                            {
                                //earlier than 8:30; can't check in yet
                                MessageBox.Show("It's too early to check in!");
                            }
                            else if ((DateTime.Now.Hour == 11 && DateTime.Now.Minute >= 30 && DateTime.Now.Minute <= 59) || (DateTime.Now.Hour == 12 && DateTime.Now.Minute == 0))
                            {
                                //between 11:30 and 12:00; check in employee, status ON TIME
                                DatabaseHelper.UpdateExistingShift(s.Id, s.Name, s.Email, s.Date, s.Sh, "ON TIME");
                                MessageBox.Show("You were successfully checked in! You are marked as ON TIME.");
                            }
                            else if (DateTime.Now.Hour == 12 && DateTime.Now.Minute >= 1 && DateTime.Now.Minute <= 30)
                            {
                                //between 12:01 and 12:30; check in employee, status LATE
                                DatabaseHelper.UpdateExistingShift(s.Id, s.Name, s.Email, s.Date, s.Sh, "LATE");
                                MessageBox.Show("You were successfully checked in! You are marked as LATE.");
                            }
                            else
                            {
                                //after 12:30; can't check in employee anymore
                                DatabaseHelper.UpdateExistingShift(s.Id, s.Name, s.Email, s.Date, s.Sh, "ABSENT");
                                MessageBox.Show("Your shift started a while ago, you can't check in anymore! You are marked as ABSENT");
                            }
                        }
                        else if (s.Sh == "evening")
                        {
                            if (DateTime.Now.Hour == 14 && DateTime.Now.Minute < 30)
                            {
                                //earlier than 14:30; can't check in yet
                                MessageBox.Show("It's too early to check in!");
                            }
                            else if ((DateTime.Now.Hour == 14 && DateTime.Now.Minute >= 30 && DateTime.Now.Minute <= 59) || (DateTime.Now.Hour == 15 && DateTime.Now.Minute == 0))
                            {
                                //between 14:30 and 15:00; check in employee, status ON TIME
                                DatabaseHelper.UpdateExistingShift(s.Id, s.Name, s.Email, s.Date, s.Sh, "ON TIME");
                                MessageBox.Show("You were successfully checked in! You are marked as ON TIME.");
                            }
                            else if (DateTime.Now.Hour == 15 && DateTime.Now.Minute >= 1 && DateTime.Now.Minute <= 30)
                            {
                                //check in employee, status LATE
                                DatabaseHelper.UpdateExistingShift(s.Id, s.Name, s.Email, s.Date, s.Sh, "LATE");
                                MessageBox.Show("You were successfully checked in! You are marked as LATE.");
                            }
                            else
                            {
                                //after 15:30; can't check in employee anymore
                                DatabaseHelper.UpdateExistingShift(s.Id, s.Name, s.Email, s.Date, s.Sh, "ABSENT");
                                MessageBox.Show("Your shift started a while ago, you can't check in anymore! You are marked as ABSENT");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("You don't have any shift scheduled for today.");
                    }
                }
            }
        }
    }
}
