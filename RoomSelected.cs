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
    public partial class RoomSelected : Form
    {
        
        public RoomSelected()
        {
            InitializeComponent();
        }

        public void ShowSelected()
        {
            this.Close();
        }

        static string name;
        public string Room(string room)
        {
            RoomLabelSelect.Text = room;
            name = room;
            return name;
        }


        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RoomSelected_Load(object sender, EventArgs e)
        {
            var data = DataModels.GetDataItem(name);
            List<int> code = data.Item1;
            List<string> Start = data.Item2;
            List<string> End = data.Item3;
            List<string> teacher = data.Item4;
            List<int> ifclass = data.Item5;

            for (int i = 0 ; i < Start.Count; i++)
            {
                string time = $"{Start[i]} - {End[i]}"; int roomcod = code[i];
                roomTimesSpanSched room = new roomTimesSpanSched(this, time, teacher[i], ifclass[i], name, roomcod);
                PanelList.Controls.Add(room);

                //Console.WriteLine(name + " " + time+" "+roomcod);

            }
        }
    }
}
