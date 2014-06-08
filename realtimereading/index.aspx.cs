using MySql.Data.MySqlClient;
using realtimereading.utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace realtimereading
{
    public partial class index : System.Web.UI.Page
    {
        private SerialPort serialPort1 = new SerialPort();
        public string reading;
        public string description;
        public string temp;
        private int interval;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd MMM yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");

            serialPort1.PortName = "COM6";
            serialPort1.BaudRate = 9600;

            SqlOperation op = new SqlOperation();
            MySqlDataReader dr = op.getInterval(int.Parse(Session["userid"].ToString()));

            dr.Read();
            interval = int.Parse(dr.GetValue(8).ToString());

            Timer3.Interval = interval * 1000;

            serialPort1.Open();
            temp = serialPort1.ReadLine();
            reading = serialPort1.ReadLine();
            description = serialPort1.ReadLine();
            serialPort1.Close();
            lblTemp.Text = temp;
            lblReading.Text = reading;
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd MMM yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        protected void Timer2_Tick(object sender, EventArgs e)
        {
            serialPort1.Open();
            temp = serialPort1.ReadLine();
            reading = serialPort1.ReadLine();
            description = serialPort1.ReadLine().ToString();
            serialPort1.Close();
            lblTemp.Text = temp;
            lblReading.Text = reading;
            lblDesc.Text = description;
        }

        protected void Timer3_Tick(object sender, EventArgs e)
        {
            SqlOperation op = new SqlOperation();
            
            op.insertTempReading(Double.Parse(temp), int.Parse(Session["userid"].ToString()));
            op.insertMoistureReading(int.Parse(reading), 1);
            Debug.Print("inserted");
            Timer3.Interval = interval * 1000;
        }
    }
}