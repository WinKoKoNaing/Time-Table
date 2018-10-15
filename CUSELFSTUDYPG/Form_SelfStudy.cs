using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Media;
using System.Collections;

namespace CUSELFSTUDYPG
{
    public partial class Form_SelfStudy : Form
    {
        Boolean oneTimeRead = true;
        SoundPlayer player;
        int nextH = 24;
        Boolean changeBtnClick = true;
        List<Schedule> schedule = new List<Schedule>();

        SqlConnection con;


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form_SelfStudy()
        {
            InitializeComponent();


        }

        private void menubar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        // current time change timer
        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Start();
            lbTime.Text = DateTime.Now.ToLongTimeString();

        }

        private void Form_SelfStudy_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Tutorials\C#_LANGUAGE\SCHOOL_EXERCISES\CUSELFSTUDYPG\CUSELFSTUDYPG\SelfStudy.mdf;Integrated Security=True");

            timer.Start();
            subjectTimer.Start();
            lbDay.Text = DateTime.Now.ToLongDateString();
            lbTime.Text = DateTime.Now.ToLongTimeString();
            dateTimeChange(DateTime.Now.ToLongDateString());
            lbCurrentDate.Text = DateTime.Now.ToLongDateString();
            btnStop.Visible = false;

            dgvTodayResult.BorderStyle = BorderStyle.None;

            dgvTodayResult.EnableHeadersVisualStyles = false;
            dgvTodayResult.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTodayResult.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvTodayResult.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTodayResult.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 5, 0, 5);


        }

        // go to newSchedule Form

        private void btnNewSchedule_Click(object sender, EventArgs e)
        {
            NewSchedule s = new NewSchedule();
            s.Show();
        }



        // button Mouse Hover

        private void lbYesterday_MouseHover(object sender, EventArgs e)
        {
            lbYesterday.BackColor = Color.SteelBlue;

        }
        private void lbYesterday_MouseLeave(object sender, EventArgs e)
        {
            lbYesterday.BackColor = Color.SlateGray;
        }
        private void lbToday_MouseHover(object sender, EventArgs e)
        {

            lbToday.BackColor = Color.SteelBlue;
        }
        private void lbToday_MouseLeave(object sender, EventArgs e)
        {
            lbToday.BackColor = Color.SlateGray;
        }
        private void lbTomorrow_MouseHover(object sender, EventArgs e)
        {
            lbTomorrow.BackColor = Color.SteelBlue;

        }
        private void lbTomorrow_MouseLeave(object sender, EventArgs e)
        {
            lbTomorrow.BackColor = Color.SlateGray;
        }

        // Button Mouse Click

        private void lbToday_Click(object sender, EventArgs e)
        {
            lbCurrentDate.Text = DateTime.Now.ToLongDateString();
            dateTimeChange(DateTime.Now.ToLongDateString());
            lbTitleDay.Text = "Today Schedule";
        }
        private void lbTomorrow_Click(object sender, EventArgs e)
        {
            lbCurrentDate.Text = DateTime.Now.AddDays(1).ToLongDateString();
            string ydate = DateTime.Now.AddDays(1).ToLongDateString();
            dateTimeChange(ydate);
            lbTitleDay.Text = "Tomorrow Schedule";
        }
        private void lbYesterday_Click(object sender, EventArgs e)
        {
            lbCurrentDate.Text = DateTime.Now.AddDays(-1).ToLongDateString();
            string ydate = DateTime.Now.AddDays(-1).ToLongDateString();
            dateTimeChange(ydate);
            lbTitleDay.Text = "Yesterday Schedule";
        }

        // click dgv
        private void dgvTodayResult_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //  string firstCellValue = dgvTodayResult.SelectedRows[0].Cells[0].Value;
            string id = dgvTodayResult[0, dgvTodayResult.CurrentRow.Index].Value.ToString();
            string subject = dgvTodayResult[2, dgvTodayResult.CurrentRow.Index].Value.ToString();
            string s = dgvTodayResult[5, dgvTodayResult.CurrentRow.Index].Value.ToString();
            if (id == null || id == "")
            {
                MessageBox.Show("You click Empty Row","Warining",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            try
            {
                checkStatusChange(id, lbCurrentDate.Text, subject, s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // dgv change values due to current time or selected time
        public void dateTimeChange(String date)
        {
            con.Open();
            string selectQuery = "select * from schedule where sdate = @sday";
            SqlCommand cmdSelect = new SqlCommand(selectQuery, con);
            cmdSelect.Parameters.AddWithValue("@sday", Convert.ToDateTime(date));
            SqlDataReader sdr = cmdSelect.ExecuteReader();

            DataTable dt = new DataTable();
            if (sdr.HasRows)
            {
                dt.Columns.Add("Id");
                dt.Columns.Add("Date");
                dt.Columns.Add("Subject");
                dt.Columns.Add("Start Time");
                dt.Columns.Add("End Time");
                dt.Columns.Add("Status");
                while (sdr.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["Id"] = sdr["id"];
                    dr["Date"] = Convert.ToDateTime(sdr["sdate"]);
                    dr["Subject"] = sdr["subject"];
                    dr["Start Time"] = sdr["StartTime"];
                    dr["End Time"] = sdr["EndTime"];
                    dr["Status"] = Convert.ToInt32(sdr["status"]) == 0 ? "Ready" : "Funished";
                    dt.Rows.Add(dr);
                }
                dgvTodayResult.AutoGenerateColumns = true;
                dgvTodayResult.DataSource = dt;
            }
            else
            {
                dgvTodayResult.DataSource = null;
            }
            con.Close();
        }



        private void dgvTodayResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        public void checkStatusChange(string id, string date, string subject, string s)
        {
           
            con.Open();
            string updateQuery = null;
            string ques = null;
            if (s.Trim() == "Ready")
            {
                ques = "Do you finish this Subject " + subject;
                updateQuery = "Update  schedule set status = 1 where Id=@id";
            }
            else
            {
                ques = "Do you unfinish this Subject " + subject;
                updateQuery = "Update  schedule set status = 0 where Id=@id";
            }

            DialogResult yes = MessageBox.Show(ques, subject + " Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yes == DialogResult.Yes)
            {

               
                try
                {
                    SqlCommand deleteCmd = new SqlCommand(updateQuery, con);
                    deleteCmd.Parameters.AddWithValue("@id", int.Parse(id));
                    deleteCmd.ExecuteNonQuery();
                }
                catch(Exception error)
                {
                    MessageBox.Show("You click Empty Row" + error.ToString());
                }
                
                
            }
            
            string selectQuery = "select * from schedule where sdate = @sday";
            SqlCommand cmdSelect = new SqlCommand(selectQuery, con);
            cmdSelect.Parameters.AddWithValue("@sday", Convert.ToDateTime(date));
            SqlDataReader sdr = cmdSelect.ExecuteReader();

            DataTable dt = new DataTable();
            if (sdr.HasRows)
            {
                dt.Columns.Add("Id");
                dt.Columns.Add("Date");
                dt.Columns.Add("Subject");
                dt.Columns.Add("Start Time");
                dt.Columns.Add("End Time");
                dt.Columns.Add("Status");
                while (sdr.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["Id"] = sdr["id"];
                    dr["Date"] = Convert.ToDateTime(sdr["sdate"]);
                    dr["Subject"] = sdr["subject"];
                    dr["Start Time"] = sdr["StartTime"];
                    dr["End Time"] = sdr["EndTime"];
                    dr["Status"] = Convert.ToInt32(sdr["status"]) == 0 ? "Ready" : "Funished";
                    dt.Rows.Add(dr);
                }
                dgvTodayResult.AutoGenerateColumns = true;
                dgvTodayResult.DataSource = dt;


            }
            else
            {

                dgvTodayResult.DataSource = null;
            }
            con.Close();
        }

        // Alarm Timers

        private void alarm_Tick(object sender, EventArgs e)
        {
            if (oneTimeRead)
            {
                con.Open();
                string selectQuery = "select * from schedule where sdate = @sday";
                SqlCommand cmdSelect = new SqlCommand(selectQuery, con);
                cmdSelect.Parameters.AddWithValue("@sday", Convert.ToDateTime(lbCurrentDate.Text));
                SqlDataReader sdr = cmdSelect.ExecuteReader();

                DataTable dt = new DataTable();
                if (sdr.HasRows)
                {
                    if (schedule.Count > 0)
                    {
                        
                        schedule.Clear();
                    }
                    while (sdr.Read())
                    {
                        Schedule s = new Schedule(sdr["sdate"].ToString(), sdr["Subject"].ToString(), sdr["startTime"].ToString(), sdr["endTime"].ToString());
                        schedule.Add(s);
                    }
                }
                con.Close();
                oneTimeRead = false;
            }

            for (int i = 0; i < schedule.Count; i++)
            {
                DateTime sdt = Convert.ToDateTime(schedule[i].startTime);
                DateTime edt = Convert.ToDateTime(schedule[i].endTime);
                DateTime dtNow = DateTime.Now;

                if (sdt.Hour == dtNow.Hour && sdt.Minute == dtNow.Minute)
                {
                    lbCurrentSubject.Text = "Now : " + schedule[i].subject;
                    try
                    {
                        player = new SoundPlayer();
                        player.SoundLocation = @"D:\\RangTone\\Loud.wav";
                        player.PlayLooping();

                        btnStop.Visible = true;
                    }
                    catch (Exception eee)
                    {
                        MessageBox.Show(eee.ToString());
                    }

                }
            }
        }

        // button Alarm
        private void btnTimer_Click(object sender, EventArgs e)
        {

            if (changeBtnClick)
            {
                alarm.Start();
                btnTimer.Text = "Alarm";
                changeBtnClick = false;
            }
            else
            {
                changeBtnClick = true;
                alarm.Stop();
                oneTimeRead = true;
                btnTimer.Text = "Not Alarm";
            }


        }

        // button Alarm Stop
        private void btnStop_Click(object sender, EventArgs e)
        {
            player.Stop();
            btnStop.Visible = false;

        }

        // label time
        private void lbTime_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Time is ...", "Thank bro");
        }

        // Reflesh Button

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimeChange(DateTime.Now.ToShortDateString());
            lbTitleDay.Text = "Today Schedule";
            subjectTimer.Stop();
            subjectTimer.Start();
            oneTimeRead = true;



        }




        // form close method

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void subjectTimer_Tick(object sender, EventArgs e)
        {

            
            if (oneTimeRead)
            {
                con.Open();
                string selectQuery = "select * from schedule where sdate = @sday";
                SqlCommand cmdSelect = new SqlCommand(selectQuery, con);
                cmdSelect.Parameters.AddWithValue("@sday", Convert.ToDateTime(lbCurrentDate.Text));
                SqlDataReader sdr = cmdSelect.ExecuteReader();

                DataTable dt = new DataTable();
                if (sdr.HasRows)
                {
                    if (schedule.Count > 0)
                    {
                        schedule.Clear();
                    }
                    while (sdr.Read())
                    {
                        Schedule s = new Schedule(sdr["sdate"].ToString(), sdr["Subject"].ToString(), sdr["startTime"].ToString(), sdr["endTime"].ToString());
                        schedule.Add(s);
                    }
                }
                con.Close();
                oneTimeRead = false;
            }
            for (int i = 0; i < schedule.Count; i++)
            {
                DateTime sdt = Convert.ToDateTime(schedule[i].startTime);
                DateTime edt = Convert.ToDateTime(schedule[i].endTime);
                DateTime dtNow = DateTime.Now;

                if (dtNow.Hour >= sdt.Hour && edt.Hour >= dtNow.Hour)
                {
                    lbCurrentSubject.Text = "Now : " + schedule[i].subject;
                }
                else
                {

                    if (sdt.Hour > dtNow.Hour)
                    {
                        int h = sdt.Hour - dtNow.Hour;
                        if (h < nextH)
                        {
                            nextH = h;
                            lbCurrentSubject.Text = "Next : " + schedule[i].subject;

                        }
                    }
                    else
                    {
                        int h = dtNow.Hour - sdt.Hour;
                        if (h < nextH)
                        {
                            nextH = h;
                            lbCurrentSubject.Text = "Last : " + schedule[i].subject;

                        }
                    }
                    nextH = 24;

                }
            }
        }



    }
}
