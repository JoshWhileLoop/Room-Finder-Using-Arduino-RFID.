using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeDataScheduling;

namespace RoomFinder_1
{
    public partial class GetRFID : Form
    {
        public static string roomName { get; set; }
        public static string techerName { get; set; }
        public static int roomCode { get; set; }
        roomTimesSpanSched me;
        static SerialPort serialPort;
        public GetRFID(roomTimesSpanSched me, bool open, string RoomCode, string RoomName)
        {
            InitializeComponent();
            this.me = me;
            roomCode = Convert.ToInt32(RoomCode);
            roomName = RoomName;
            LoadId(open);
        }
        public void LoadId(bool b)
        {
            if (b == true)
            {
                TeacherName.Text = "Swipe your card, To Scan..";
                serialPort = new SerialPort("COM4", 9600);
                serialPort.DataReceived += SerialPort_DataReceived;

                try
                {
                    serialPort.Open();
                }
                catch (Exception)
                {
                    TeacherName.Text = "Connection Error";
                    serialPort.Close();
                }
            }
        }
        public void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string receiveData = sp.ReadLine();
            string data = receiveData.Substring(0, 11);
            Get(data);
        }
        public async void Get(string id)
        {
            techerName = DataModels.GetTeacher(id);

            //Console.WriteLine($"Name Gets: {techerName}");
            Invoke(new Action(() => { TeacherName.Text = "\t\t\t\t\t\t\t Received....."; }));

            if (techerName == "No")
            {
                await Task.Delay(3000);
                Invoke(new Action(() => { TeacherName.Text = "Sorry This card is not registered,\nPlease Contact To the Admin or Joshua"; }));
                Invoke(new Action(() => { btn_yes.Visible = false; }));
                serialPort.Close();
            }
            else
            {
                await Task.Delay(3000);
                Invoke(new Action(() => { TeacherName.Text = $"Hello {techerName}\n Do you want to use this room?"; }));
                Invoke(new Action(() => { btn_yes.Visible = true; }));
                serialPort.Close();
            }
        }

        public static void DataUpdate()
        {
            //MessageBox.Show($"room Name: {roomName} teacher: {techerName} code: {roomCode}");
            //Console.WriteLine($"RoomName: {roomName} Class: 1 teaher: {techerName} Room Code: {roomCode}");
            DataModels.UpdateDataStatus(1, techerName, roomCode);
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            DataUpdate();
            serialPort.Close();
            Invoke(new Action(() => Hide()));
            LoadId(false);
            TeacherName.Text = "";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            TeacherName.Text = "";
            serialPort.Close();
            Invoke(new Action(() => Hide()));
            LoadId(false);
        }
    }
}