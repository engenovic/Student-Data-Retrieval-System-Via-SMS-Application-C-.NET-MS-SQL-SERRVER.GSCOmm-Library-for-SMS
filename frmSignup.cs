using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.VisualBasic;

namespace SDRS
{
    public partial class frmSignup : Form
    {
        public frmSignup()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=ENGINEERNGENO;Initial Catalog=SDRS;Integrated Security=True");
        }
        // Database variables
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;
        // For dealing with the image
        MemoryStream ms;
        byte[] photo_aray;
        // Alert function
        public void Alert(string msg, Alert.alertTypeEnum type)
        {
            Alert f = new Alert();
            f.setAlert(msg, type);
        }
        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmSignup_Load(object sender, EventArgs e)
        {
            // Security Questions
            cbxSecQ.Text = "Select Security Question";
            cbxSecQ.Items.Add("What primary school did you attend?");
            cbxSecQ.Items.Add("What was the last name of your third-grade teacher?");
            cbxSecQ.Items.Add("Where were you on New Year’s Eve in 2020? ");
            // Roles 
            cbxRole.Items.Add("Exams");
            cbxRole.Items.Add("Fees");
            cbxRole.Items.Add("Admin");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            // Check to see  if the useralready exist 
            try
            {
                adapter = new SqlDataAdapter("select * from tblUsers WHERE Username= '" + txtUsername.Text + "'", con);
                ds = new DataSet();
                adapter.Fill(ds, "tblUsers");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.Alert(" A user with that username already Exists!!", SDRS.Alert.alertTypeEnum.Error);
                }
                //If user not exist proceed to register
                else
                {
                    try
                    {
                        cmd = new SqlCommand("INSERT into tblUsers(Username,Password,Role,SQuestion,SAnswer,Status) values('" + txtUsername.Text + "','" + txtPass.Text + "','" + cbxRole.Text + "','" + cbxSecQ.Text + "','" + txtSecAns.Text + "', 'Denied')", con);
                        
                        con.Open();
                        int n = cmd.ExecuteNonQuery();
                        con.Close();
                        if (n > 0)
                        {
                            this.Alert("Your request has beeen submitted Successfully . Await confirmation", SDRS.Alert.alertTypeEnum.Success);
                            
                        }
                        else
                            this.Alert("Unable to Signup User!", SDRS.Alert.alertTypeEnum.Warning);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        this.Alert("Unable to perform Insertion Operation!!", SDRS.Alert.alertTypeEnum.Error);
                        //MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                this.Alert("Unable to perform Query Operation!!", SDRS.Alert.alertTypeEnum.Error);
                //MessageBox.Show(ex.Message);
                con.Close();
            }
           
        }
        

        

        private void btnClose12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
