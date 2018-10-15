using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace CUSELFSTUDYPG
{
    public partial class NewSchedule : Form
    {
        SqlConnection con;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public NewSchedule()

        {

            InitializeComponent();
        }
        // To move pannel
        private void newScheduleHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        // Form Load
        private void NewSchedule_Load(object sender, EventArgs e)
        {

            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Tutorials\C#_LANGUAGE\SCHOOL_EXERCISES\CUSELFSTUDYPG\CUSELFSTUDYPG\SelfStudy.mdf;Integrated Security=True");

            dateTimeChange(DateTime.Now.ToLongDateString());
            DateTime dt = dtpET.Value.AddHours(1);
            dtpET.Value = dt;


            dgvReview.BorderStyle = BorderStyle.None;

            dgvReview.EnableHeadersVisualStyles = false;
            dgvReview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvReview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvReview.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 5, 0, 5);

        }

       


        // Add Button click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbResult.Text = dtpDate.Value.ToLongDateString();
            if (txtSubject.Text != "" && txtSubject.Text != null)
            {
                
                con.Open();
                string insertQuery = "insert into Schedule(Sdate,Subject,StartTime,EndTime) values(@sdate,@subject,@st,@et)";
                SqlCommand cmd = new SqlCommand(insertQuery, con);

                //dtpDate.CustomFormat = "dd-MM-yyyy";

                cmd.Parameters.AddWithValue("@sdate", Convert.ToDateTime(dtpDate.Value.ToLongDateString()));
                cmd.Parameters.AddWithValue("@subject", txtSubject.Text);
                cmd.Parameters.AddWithValue("@st", dtpST.Value.ToLongTimeString());
                cmd.Parameters.AddWithValue("@et", dtpET.Value.ToLongTimeString());
                cmd.ExecuteNonQuery();

                string selectQuery = "select * from schedule where sdate = @sday";
                SqlCommand cmdSelect = new SqlCommand(selectQuery, con);
                cmdSelect.Parameters.AddWithValue("@sday", Convert.ToDateTime(dtpDate.Value.ToLongDateString()));
                SqlDataReader sdr = cmdSelect.ExecuteReader();

                DataTable dt = new DataTable();
                if (sdr.HasRows)
                {
                    dt.Columns.Add("Id");
                    dt.Columns.Add("Date");
                    dt.Columns.Add("Subject");
                    dt.Columns.Add("Start Time");
                    dt.Columns.Add("End Time");
                    while (sdr.Read())
                    {
                        DataRow dr = dt.NewRow();
                        dr["id"] = sdr["id"];
                        dr["Date"] = Convert.ToDateTime(sdr["sdate"]);
                        dr["Subject"] = sdr["subject"];
                        dr["Start Time"] = sdr["StartTime"];
                        dr["End Time"] = sdr["EndTime"];
                        dt.Rows.Add(dr);
                    }
                    dgvReview.AutoGenerateColumns = true;
                    dgvReview.DataSource = dt;
                }
            }
            else
            {
                lberror.Text = "Enter Subject";
            }
            con.Close();

        }

       

        // Date Time Change due to Click date
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
                while (sdr.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["Id"] = sdr["id"];
                    dr["Date"] = Convert.ToDateTime(sdr["sdate"]);
                    dr["Subject"] = sdr["subject"];
                    dr["Start Time"] = sdr["StartTime"];
                    dr["End Time"] = sdr["EndTime"];
                    dt.Rows.Add(dr);
                }
                dgvReview.AutoGenerateColumns = true;
                dgvReview.DataSource = dt;
                lbResult.Text = ""+date;
            }
            else
            {
                lbResult.Text = "No Result";
                dgvReview.DataSource = null;
            }
            con.Close();
        }
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimeChange(dtpDate.Value.ToLongDateString());
        }

       
        // Dgv Click to Delete
        public void RowDelete(string id,string date)
        {
            con.Open();
            
            DialogResult yes = MessageBox.Show("Are you sure to detete this row " + id, "Delete Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yes == DialogResult.Yes)
            {
                string deleteQuery = "delete  from schedule where Id=@id";
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, con);
                deleteCmd.Parameters.AddWithValue("@id", int.Parse(id));
                deleteCmd.ExecuteNonQuery();
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
                while (sdr.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["Id"] = sdr["id"];
                    dr["Date"] = Convert.ToDateTime(sdr["sdate"]);
                    dr["Subject"] = sdr["subject"];
                    dr["Start Time"] = sdr["StartTime"];
                    dr["End Time"] = sdr["EndTime"];
                    dt.Rows.Add(dr);
                }
                dgvReview.AutoGenerateColumns = true;
                dgvReview.DataSource = dt;
                lbResult.Text = "Date : " + date;
                dgvReview.Refresh();
            }
            else
            {
                lbResult.Text = "No Result";
                dgvReview.DataSource = null;
            }
            con.Close();
        }
        private void dgvReview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string firstCellValue = dgvReview[0, dgvReview.CurrentRow.Index].Value.ToString();
                RowDelete(firstCellValue, dtpDate.Value.ToLongDateString());
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        // Date Time check 
        public void checkedHour(DateTimePicker start, DateTimePicker end)
        {
            con.Open();


            
            string selectQuery = "select * from schedule where sdate = @sday";
            SqlCommand cmdSelect = new SqlCommand(selectQuery, con);
            cmdSelect.Parameters.AddWithValue("@sday", Convert.ToDateTime(dtpDate.Value.ToShortDateString()));
            SqlDataReader sdr = cmdSelect.ExecuteReader();


            string error = "";


            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    DateTime sdt = Convert.ToDateTime(sdr["startTime"]);
                    DateTime edt = Convert.ToDateTime(sdr["endTime"]);
                    if (start.Value.Hour == sdt.Hour)
                    {
                       
                        if (start.Value.Minute > sdt.Minute)
                        {
                            error = "This is already Scheduling. Subject is " + sdr["subject"] + "From " + sdr["startTime"] + " To " + sdr["endTime"];
                        }
                    }
                    if (start.Value.Hour == end.Value.Hour)
                    {
                        error = "Start Time equal End Time";
                    }
                    if (end.Value.Hour == sdt.Hour)
                    {
                        if (end.Value.Minute > sdt.Minute)
                        {

                            error = "This is already Scheduling. Subject is " + sdr["subject"] + "From " + sdr["startTime"] + " To " + sdr["endTime"];
                        }
                    }
                    if (start.Value.Hour == sdt.Hour && end.Value.Hour == edt.Hour)
                    {

                        if (start.Value.Minute > sdt.Minute)
                        {

                            error = "This is already Scheduling. Subject is " + sdr["subject"] + "From " + sdr["startTime"] + " To " + sdr["endTime"];
                        }
                        if (end.Value.Minute > edt.Minute)
                        {

                            error = "This is already Scheduling. Subject is " + sdr["subject"] + "From " + sdr["startTime"] + " To " + sdr["endTime"];
                        }
                    }
                    if (sdt.Hour >= start.Value.Hour && edt.Hour <= end.Value.Hour)
                    {

                        error = "This is already Scheduling. Subject is " + sdr["subject"] + "From " + sdr["startTime"] + " To " + sdr["endTime"];
                    }
                    if (sdt.Hour < start.Value.Hour && edt.Hour > start.Value.Hour)
                    {

                        error = "This is already Scheduling. Subject is " + sdr["subject"] + "From " + sdr["startTime"] + " To " + sdr["endTime"];
                      
                    }
                    if (sdt.Hour < end.Value.Hour && edt.Hour > end.Value.Hour)
                    {
                        error = "This is already Scheduling. Subject is " + sdr["subject"] + "From " + sdr["startTime"] + " To " + sdr["endTime"];
                    }
                    if (edt.Hour == start.Value.Hour)
                    {
                        if (edt.Minute > start.Value.Minute)
                        {
                            error = "This is already Scheduling. Subject is " + sdr["subject"] + "From " + sdr["startTime"] + " To " + sdr["endTime"];
                        }
                    }
                    if (start.Value.Hour > end.Value.Hour)
                    {
                        error = "This is impossible because start time is greater than end time!";
                    }
                }
            }
            else
            {
               
            }

            if (error != "")
            {
                lberror.Visible = true;
                lberror.Text = error;
                btnAdd.Enabled = false;
                error = "";
            }
            else
            {
                btnAdd.Enabled = true;
                lberror.Visible = false;
            }
            con.Close();
            
        }

        private void dtpST_ValueChanged(object sender, EventArgs e)
        {
            checkedHour(dtpST, dtpET);
        }

        private void dtpET_ValueChanged(object sender, EventArgs e)
        {
            checkedHour(dtpST, dtpET);
        }

        

       
        // form Close 

        private void pbCloseNewSchedule_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        

       
    }
   
}
