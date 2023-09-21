using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using TimeDataScheduling;

namespace RoomFinder_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataModels.nameData();
            DataModels.CreateData();
            //OpeningLoad load = new OpeningLoad(this);
            //load.LoadingPage();
            TimeTick.Start();
        }

        private void TimeTick_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            Clock.Text = dateTime.ToString("T");
            TimeSpan span = dateTime.TimeOfDay;
            //RoomSelected room = new RoomSelected();
            ImageButton(span);
            LabelButton(span);
        }
        public void ImageButton(TimeSpan current)
        {
            MainDisplay mainDisplay = new MainDisplay();
            Room1.Image = mainDisplay.RoomImage("Room1", current);
            Room2.Image = mainDisplay.RoomImage("Room2", current);
            Room3.Image = mainDisplay.RoomImage("Room3", current);
            Room4.Image = mainDisplay.RoomImage("Room4", current);
        }
        public void LabelButton(TimeSpan current)
        {
            MainDisplay mainDisplay = new MainDisplay();
            room1Time.Text = mainDisplay.RoomTimeGet("Room1", current);
            room2Time.Text = mainDisplay.RoomTimeGet("Room2", current);
            room3Time.Text = mainDisplay.RoomTimeGet("Room3", current);
            room4Time.Text = mainDisplay.RoomTimeGet("Room4", current);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void Room1_Click(object sender, EventArgs e)
        {
            RoomSelected room = new RoomSelected();
            room.Room("Room1");
            room.Show();
        }

        private void Room2_Click(object sender, EventArgs e)
        {
            RoomSelected room = new RoomSelected();
            room.Room("Room2");
            room.Show();
        }

        private void Room3_Click(object sender, EventArgs e)
        {
            RoomSelected room = new RoomSelected();
            room.Room("Room3");
            room.Show();
        }

        private void Room4_Click(object sender, EventArgs e)
        {
            RoomSelected room = new RoomSelected();
            room.Room("Room4");
            room.Show();
        }
    }
}
