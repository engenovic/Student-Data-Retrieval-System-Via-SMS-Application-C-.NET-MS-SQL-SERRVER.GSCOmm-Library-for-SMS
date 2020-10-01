using SDRS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using GsmComm.GsmCommunication;
using GsmComm.PduConverter;
using GsmComm.Server;
using System.Media;
using GsmComm.PduConverter.SmartMessaging;
using System.ComponentModel;
// Developed By Engineer Ngeno | Brivic @2020
// Final Year Project 
// Meru University of Science & Technology
//******** Supervised by Dr. Chege Amos Kirongo **** DPt. Computer Science 
namespace SDRS
{
    public partial class frmDashb : Form
    {
        public frmDashb()
        { 
            InitializeComponent();
            hideSubMenu();
            con = new SqlConnection("Data Source=ENGINEERNGENO;Initial Catalog=SDRS;Integrated Security=True");

        }
       
        public GsmCommMain comm = new GsmCommMain("COM93", 9600, 150);
       public SerialPort sp = new SerialPort("COM93", 9600);

        // Database variables
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        DataSet ds;
        DataRow row;
        int rno;
        // SMS Variables 
        string a;
        string b;
        string c;
        string d;
        string ee;
        string f;
        public void Alert(string msg, Alert.alertTypeEnum type)
        {
            Alert f = new Alert();
            f.setAlert(msg, type);
        }
        
        int counter;
        private void frmDashb_Load(object sender, EventArgs e)
        {
            
            
        }
        // Hide Menu Function
        private void hideSubMenu()
        {
            panelStudentSub.Visible = false;
            panelExamSub.Visible = false;
            panelFeesSub.Visible = false;
            panelToolsSub.Visible = false;
        }
        
        // Display Menu According to Logged in User
        public  void UpdateExam(bool ex)
        {
            btnStudents.Enabled = false;
            btnFees.Enabled = false;
            btnTools.Enabled = false;
            btnMessage.Enabled = false;
            gunaCirclePictureBox1.Image = Resources.Brigit_Chelangat;
        }
        public void UpdateFees(bool fe)
        {
            btnStudents.Enabled = false;
            btnExams.Enabled = false;
            btnTools.Enabled = false;
            btnMessage.Enabled = false;
           gunaCirclePictureBox1.Image= Resources.Brigit_Chelangat1;
        }
        public string labelUser
        {
            get{
                return this.label4.Text;
            }
            set
            {
                this.label4.Text = value;
            }
        }
        public string labelRole
        {
            get
            {
                return this.label2.Text;
            }
            set
            {
                this.label2.Text = value;
            }
        }
        
        // Show Menu Function
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        // Open SubMenus 
        private void btnStudents_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStudentSub);
        }

        

        private void btnExams_Click(object sender, EventArgs e)
        {
            showSubMenu(panelExamSub);
        }
        private void btnFees_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFeesSub);
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSMSSend());
            //
            //Other Code
            //
            hideSubMenu();
        }

        private void btnTools_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSub);
        }
        #region ToolsSubMenu
        
        #endregion

        // Check current active form and set run-time properties 
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //Open Child Forms 
        // Add Student Form
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAddStudent());
            //
            //Other Code
            //
            hideSubMenu();
        }
        // View Students form
        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewStudents());
            //
            //Other Code
            //
            hideSubMenu();
        }
        // Edit Exam Info Formss
        private void btnExamInfo_Click(object sender, EventArgs e)
        {
            openChildForm(new frmExamInfo());
            //
            //Other Code
            //
            hideSubMenu();
        }

        private void btnExamMark_Click(object sender, EventArgs e)
        {
            openChildForm(new frmExamMark());
            //
            //Other Code
            //
            hideSubMenu();
        }

        private void btnExamResult_Click(object sender, EventArgs e)
        {
            openChildForm(new frmExamResult());
            //
            //Other Code
            //
            hideSubMenu();
        }
        private void btnFeeBill_Click(object sender, EventArgs e)
        {
            openChildForm(new frmFeeBill());
            //
            //Other Code
            //
            hideSubMenu();
            //..
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            openChildForm(new frmInfo());
            //
            //Other Code
            //
            hideSubMenu();
            //..
        }
        private void btnPayFees_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPayFees());
            //..
            //your codes
            //..
            hideSubMenu();
        }

       

        
        private void btnUsers_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUsers());
            //..
            //your codes
            //..
            hideSubMenu();
        }
        private void btnViewPayment_Click(object sender, EventArgs e)
        {
            openChildForm(new frmViewPayments());
            //..
            //your codes
            //..
            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login= new frmLogin();
            login.Show();
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if(panelSideMenu.Width==250 & panelSideMenu.Height==661)
            {
                panelSideMenu.Width = 48;
                panelSideMenu.Height =661;
                btnStudents.Visible = false;
                btnExams.Visible = false;
                btnFees.Visible = false;
                btnMessage.Visible = false;
                btnTools.Visible = false;
                btnExit.Visible = false;
            }
            else
            {
                panelSideMenu.Width = 250;
                panelSideMenu.Height = 661;
                btnStudents.Visible = true;
                btnExams.Visible = true;
                btnFees.Visible = true;
                btnMessage.Visible = true;
                btnTools.Visible = true;
                btnExit.Visible = true;
            }
        }

        
        
        
       
        
        public void rcv()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:\\Users\\NGENO VICTOR\\Desktop\\FINAL YEAR PROJECT\\SDRS\\IMPLEMENTATION\\files\\rcv.wav";
            player.Play();
        }
        public void snd()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:\\Users\\NGENO VICTOR\\Desktop\\FINAL YEAR PROJECT\\SDRS\\IMPLEMENTATION\\files\\snd.wav";
            player.Play();
        }


       

        public void readSMS()
        {
           // SerialPort sp = new SerialPort("COM78", 9600);
            string InputData = String.Empty;
            sp.Parity = Parity.None;
            sp.DataBits = 8;
            sp.StopBits = StopBits.One;
            sp.Handshake = Handshake.XOnXOff;

            sp.DtrEnable = true;
            sp.RtsEnable = true;
            sp.NewLine = Environment.NewLine;
            try
            {
                sp.Open();

                // Make the Modem begin  to Accept Commands
                sp.Write("AT" + System.Environment.NewLine);
                Thread.Sleep(1000);

                // Put Modem in Text Mode 
                sp.WriteLine("AT+CMGF=1" + System.Environment.NewLine); // replace with 0 for other characters not English
                Thread.Sleep(1000);

                // List all UNREAD Messages 
                sp.WriteLine("AT+CMGL=\"REC UNREAD\"\r" + System.Environment.NewLine);// "AT+CMGL=\"REC UNREAD\"\r"
                Thread.Sleep(3000);
                // MessageBox.Show(sp.ReadExisting());
                Regex r = new Regex(@"\+CMGL: (\d+),""(.+)"",""(.+)"",(.*),""(.+)""\r\n(.+)\r\n");
                InputData = sp.ReadExisting();
                if (InputData != String.Empty)
                {
                    Match m = r.Match(InputData);// Check if there is data
                    while (m.Success)
                    {
                        //this.Alert("New Message!", SDRS.Alert.alertTypeEnum.Info);
                        rcv();
                        a = m.Groups[1].Value;// Index of the SMS
                        b = m.Groups[2].Value;// Status
                        c = m.Groups[3].Value;// Number
                        d = m.Groups[4].Value;// Space
                        ee = m.Groups[5].Value;// Date / Time 
                        f = m.Groups[6].Value;// Message
                                              // log the SMS in the database 
                        sp.Close();
                        LogSMS(a, c, ee, f);
                        //sysbusy(c);



                        ListViewItem item = new ListViewItem(new string[] { a, b, c, d, ee, f });
                        listView1.Items.Add(item);
                        m = m.NextMatch();
                    }
                    Thread.Sleep(3000);
                    listView1.Refresh();
                    listView1.Items.Clear();
                    // Continuously Poll the COMP Port to check new UNREAD Message 
                    readSMS();
                   
                }
                else
                    label6.Text = "No New Message";
            }
            catch (Exception ex)
            {
                
                sp.Close();
                readSMS();
            }


        }

        void LogSMS(string i, string no, string dt, string m)
        {
            DateTime today = new DateTime();
            today = DateTime.Now;
            if (IsRegistered(no) == true)
            {
                try
                {
                    cmd = new SqlCommand("INSERT into tblInbox(Indexm,Status,Number,DTime,Message) values('" + i + "','REC READ','" + no + "','" + today + "','" + m + "' )", con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();
                    con.Close();
                    if (n > 0)
                    {
                        //Call Process SMS
                        //frmExamMark fm = new frmExamMark();
                        //fm.PullExam(no,1672);
                        //Thread.Sleep(1000);
                        // Process the Query 
                        string str = m;
                        if (str.Contains("#") == true && str.Length == 7)
                        {

                            string[] strArr = null;
                            char[] splitchar = { '#' };
                            strArr = str.Split(splitchar);
                            var last = strArr.Last();
                            string first = strArr.First();
                            int admno = Convert.ToInt32(first);
                            // MessageBox.Show(first);
                            // Compare strings using String.Equals  
                            if (String.Equals(last, "ER"))
                            {
                                // UpdateStatus(msgid);
                                // MessageBox.Show(last+ "Exam Result" + first);
                                frmExamMark exm = new frmExamMark();
                                exm.PullExam(no, admno);

                            }

                            else if (String.Equals(last, "FB"))
                            {

                                

                                frmPayFees pf = new frmPayFees();
                                pf.PullFeesBal(no, admno);
                                //MessageBox.Show("Fees Balance");

                            }
                            else if (String.Equals(last, "FS"))
                            {

                                

                                frmPayFees pf = new frmPayFees();
                                pf.PullFeeState(no, admno);
                                //MessageBox.Show("Fees Statement");

                            }
                            else
                            {
                                // UpdateStatus(msgid);

                                // MessageBox.Show("Wrong Format");
                                AutoSMS("Dear Parent, you have entered a wrong query Format. The Correct Format is ADMNo#QUERY. Thank You", no);
                                // UpdateStatus(no);
                            }
                        }
                        else
                        {
                            // UpdateStatus(msgid);
                            AutoSMS("Hello Parent, you have entered a wrong query Format. The Correct Format is ADMNO#QUERY. Thank You", no);
                        }
                        


                    }
                    else
                        this.Alert("Unable to Read Messages!", SDRS.Alert.alertTypeEnum.Warning);
                }
                catch (Exception ex)
                {
                    this.Alert("Unable to perform Insertion Operation!!", SDRS.Alert.alertTypeEnum.Error);
                    MessageBox.Show(ex.Message + "LSMS");
                    con.Close();
                }
            }
            else
                AutoSMS("Access denied,  we could not find your phone number! Help Line: 0707142565", no);

        }
        bool IsRegistered(string pno)
        {
            
            try
            {
                // Getting New Messages from Inbox table 
                adapter = new SqlDataAdapter("SELECT* FROM tblStudents WHERE PhoneNo= '" + pno + "'", con);
                ds = new DataSet();
                adapter.Fill(ds, "Parents");
                adapter.Fill(dt);

                int rs = ds.Tables[0].Rows.Count;

                if (rs > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public void AutoSMS(string m, string n)
        {
           
            try
            {
               // GsmCommMain comm = new GsmCommMain("COM78", 9600, 150);
                comm.Open();
                bool unicode = true;
                SmsSubmitPdu[] pdu = SmartMessageFactory.CreateConcatTextMessage(m, unicode, n);
                comm.SendMessages(pdu);
                comm.Close();
                // this.Alert("Message Sent!", SDRS.Alert.alertTypeEnum.Success);

                snd();
            }
           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }

        }

        

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {

            BackgroundWorker bw = new BackgroundWorker();
           // this.Controls.Add(bw);
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerAsync();
        }

private bool quit = false;
        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!quit)
            {
                readSMS();
            }
        }

        public void StopWorker()
        {
            
            bw.Dispose();
            bw = null;
            GC.Collect();
        }
        
        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
        
        bw.CancelAsync();
            

        }
    }
    }
