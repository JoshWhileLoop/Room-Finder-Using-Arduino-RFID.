using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace TimeDataScheduling
{
    public class DataModels
    {
        static SqlConnection connection = new SqlConnection(@"Data Source = AME10\SQLEXPRESS; Initial Catalog = RoomSchedule; Integrated Security = True");

        public static string nameData()
        {
            DateTime date = DateTime.Now;
            string name = date.ToString("MMM_dddd_dd_yyy");
            return name;
        }

        // CREATE data
        public static async void CreateData()
        {
            string TableName = nameData();

            connection.Open();
            var checkTable = connection.CreateCommand();
            checkTable.CommandText = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{TableName}'";
            int tableCount = Convert.ToInt32(checkTable.ExecuteScalar());

            if (tableCount > 0)
            {
                Console.WriteLine($"{TableName} is already exists.");
                connection.Close();
            }
            else
            {
                var tableCmd = connection.CreateCommand();
                tableCmd.CommandText = $@"
                CREATE TABLE {TableName} (
                Room VARCHAR(50) NOT NULL,
                StartTime VARCHAR(50) NULL,
                EndTime VARCHAR(50) NULL,
                ClassTime INTEGER CHECK (ClassTime IN (0, 1)) NOT NULL,
                Section VARCHAR(50),
                Teacher VARCHAR(50),
                RoomCode INTEGER PRIMARY KEY IDENTITY (1,1)
                )";
                tableCmd.ExecuteNonQuery();

                Console.WriteLine($"{TableName} is created.");

                connection.Close();
                await Schedule();
            }
        }
        public static async Task Schedule()
        {
            connection.Open();
            var views = connection.CreateCommand();
            views.CommandText = "SELECT * FROM MainSchedule";
            SqlDataReader reader = views.ExecuteReader();

            List<TimeSchedule> sched = new List<TimeSchedule>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    sched.Add(
                    new TimeSchedule
                    {
                        roomName = reader.GetString(0),
                        start = reader.GetString(1),
                        end = reader.GetString(2),
                        classTime = reader.GetInt32(3),
                        section = reader.GetString(4),
                        teacher = reader.GetString(5),
                        roomCode = reader.GetInt32(6)
                    });
                }
            }
            connection.Close();

            foreach (var i in sched)
            {
                AddToData(i.roomName, i.start, i.end, i.classTime, i.section, i.teacher);
                await DelayMemory();
                Console.WriteLine($"Data Added: {i.roomName}");
            }
        }

        // INSERT Data
        public static void AddToData(string roomName, string Start, string End, int ifclass, string Section, string Teacher)
        {
            string name = nameData();
            connection.Open();
            var insertSched = connection.CreateCommand();
            insertSched.CommandText = $"INSERT INTO {name} (Room, StartTime, EndTime, ClassTime, Section, Teacher) VALUES ('{roomName}', '{Start}', '{End}', {ifclass}, '{Section}', '{Teacher}')";
            insertSched.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Data Transfer Successfully");
        }
        public static async Task DelayMemory()
        {
            //Console.Clear();
            Console.Write("Loading");
            for (int i = 0; i < 5; i++)
            {
                await Task.Delay(70);
                Console.Write(".");
            }
            //Console.Clear();
        }

        public static (List<string>, List<string>, List<int>) GetTimeSpan(string room)
        {
            List<string> StartTime = new List<string>();
            List<string> EndTime = new List<string>();
            List<int> hasClass = new List<int>();

            List<TimeSchedule> schedules = GetSched();

            var list = from sched in schedules
                       where sched.roomName == room
                       select sched;

            foreach (var i in list)
            {
                StartTime.Add(i.start); EndTime.Add(i.end); hasClass.Add(i.classTime);
            }

            return (StartTime, EndTime, hasClass);
        }

        public static List<TimeSchedule> GetSched()
        {
            string name = nameData();
            List<TimeSchedule> sched = new List<TimeSchedule>();
            
            try
            {
                connection.Open();
                var views = connection.CreateCommand();
                views.CommandText = $"SELECT * FROM {name}";
                SqlDataReader reader = views.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        sched.Add(
                        new TimeSchedule
                        {
                            roomName = reader.GetString(0),
                            start = reader.GetString(1),
                            end = reader.GetString(2),
                            classTime = reader.GetInt32(3),
                            section = reader.GetString(4),
                            teacher = reader.GetString(5),
                            roomCode = reader.GetInt32(6)
                        });
                    }
                }
            }
            catch (Exception e)
            {
                connection.Close();
                MessageBox.Show($"Getting Sched Error: {e}");
            }
            
            connection.Close();
            return sched;
        }
    

        public static (List<int>, List<string>, List<string>, List<string>, List<int>) GetDataItem(string RoomName)
        {
            List<int> roomcode = new List<int>();
            List<string> StartTime = new List<string>();
            List<string> EndTime = new List<string>();
            List<string> teacher = new List<string>();
            List<int> ifclass = new List<int>();


            List<TimeSchedule> schedules = GetSched();

            var list = from sched in schedules
                       where sched.roomName == RoomName
                       select sched;

            foreach (var i in list)
            {
                roomcode.Add(i.roomCode); StartTime.Add(i.start); EndTime.Add(i.end); teacher.Add(i.teacher); ifclass.Add(i.classTime);           
            }

            connection.Close();
            return (roomcode, StartTime, EndTime, teacher, ifclass);
        }

        public static void UpdateDataStatus(int classtime, string teacher, int code)
        {
            string name = nameData();
            try
            {
                connection.Open();
                var updateStatus = connection.CreateCommand();
                updateStatus.CommandText = $"UPDATE {name} SET ClassTime = {classtime}, Teacher = '{teacher}' WHERE RoomCode = {code}";
                updateStatus.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("Updated Succesfully");
            }
            catch (Exception e)
            {
                connection.Close();
                MessageBox.Show($"Updating Status Error: {e}");
            }

            connection.Close();
        }

        // Teacher Data

        public static string GetTeacher(string receivedRFID)
        {
            try
            {
                connection.Open();
                var getData = connection.CreateCommand();
                getData.CommandText = $"SELECT * FROM Teachers WHERE RFID = '{receivedRFID}'";
                SqlDataReader reader = getData.ExecuteReader();
                if (reader.Read())
                {
                    string name = reader.GetString(0);
                    connection.Close();
                    return name;
                }
            }
            catch (Exception e)
            {
                connection.Close();
                MessageBox.Show($"Get Teacher Error: {e}");
            }

            connection.Close();

            return "No";
        }
    }
    
    public class TimeSchedule
    {
        public string roomName { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public int classTime { get; set; }
        public string section { get; set; }
        public string teacher { get; set; }
        public int roomCode { get; set; }
    }
}
