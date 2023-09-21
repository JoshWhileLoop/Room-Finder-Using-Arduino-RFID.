using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeDataScheduling;

namespace RoomFinder_1
{
    public partial class roomTimesSpanSched : UserControl
    {
        RoomSelected roomselected;
        public static string roomName { get; set; }
        public roomTimesSpanSched(RoomSelected room, string clock, string teachername, int classA, string RoomName, int code)
        {
            InitializeComponent();
            roomName = RoomName;
            RoomTime(room, clock, teachername, classA, code);

        }

        public void RoomTime(RoomSelected room, string clock, string teachername, int classA, int code)
        {
            roomselected = room;
            Clock.Text = clock;

            if (classA != 1)
            {
                roomCode.Text = Convert.ToString(code);
                Status.Text = "Available";
                teacher.Text = "You can use this room..";
                btn_usethis.Visible = true;
            }
            else
            {
                Status.Text = "Class Time";
                teacher.Text = teachername;
                btn_usethis.Visible = false;
            }
        }

        private void btn_usethis_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"room Name: {roomName} code: {roomCode.Text} time: {Clock.Text}");
            roomselected.ShowSelected();
            GetRFID rfid = new GetRFID(this, true, roomCode.Text, roomName);
            rfid.Show();
        }
    }
}
